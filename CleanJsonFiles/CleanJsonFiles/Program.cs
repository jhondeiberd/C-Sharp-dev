using CleanLibDump.Model;
using Newtonsoft.Json;
using System.Reflection;
using Formatting = System.Xml.Formatting;

namespace CleanLibDump
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new JsonProcessor();

            //string sourceTest = "C:\\SoftwareData\\CCA.LSP.API\\Json response Test\\Oct-15\\Compare\\DEV\\Test";
            string folderName = "Test";
            string path = "C:\\SoftwareData\\";
            string sourceDEV = $"{path}\\{folderName}\\JsonInitial\\DEV";
            string sourcePRD = $"{path}\\{folderName}\\JsonInitial\\PRD";
            string sourceClean = $"{path}\\{folderName}\\JsonProcessed";
            try
            {
                Directory.Delete(sourceClean, true);
                //Directory.Delete(Path.Combine(sourceClean, "Test"), true);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //processor.ProcessDirectory(sourceTest, Path.Combine(sourceClean, "Test"));
            processor.ProcessDirectory(sourceDEV, Path.Combine(sourceClean, "DEV"));
            processor.ProcessDirectory(sourcePRD, Path.Combine(sourceClean, "PRD"));

        }
    }

    public class JsonProcessor
    {
        public void ProcessDirectory(string sourcePath, string destinationPath)
        {
            Directory.CreateDirectory(destinationPath);
            var jsonFiles = Directory.GetFiles(sourcePath, "*.json");

            foreach (var jsonFile in jsonFiles)
            {
                ProcessFile(jsonFile, destinationPath);
            }
        }

        private void ProcessFile(string jsonFilePath, string destPath)
        {
            try
            {
                string jsonString = File.ReadAllText(jsonFilePath);
                var currentLibraryBooklist = JsonConvert.DeserializeObject<List<LibraryBook>>(jsonString);

                if (currentLibraryBooklist == null || !currentLibraryBooklist.Any())
                    return;

                var cleanLibraryBooklist = currentLibraryBooklist.Select(CleanBook).ToList();
                cleanLibraryBooklist = cleanLibraryBooklist.OrderBy(x => x.BibID).ToList();

                string fileName = Path.GetFileName(jsonFilePath);
                string destinationFile = Path.Combine(destPath, $"Cleaned_{fileName}");

                var jsonSettings = new JsonSerializerSettings
                {
                    Formatting = (Newtonsoft.Json.Formatting)Formatting.Indented,
                    NullValueHandling = NullValueHandling.Ignore
                };

                string cleanedJson = JsonConvert.SerializeObject(cleanLibraryBooklist, jsonSettings);
                File.WriteAllText(destinationFile, cleanedJson);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in the file {jsonFilePath}: {ex.Message}");
            }
        }

        public LibraryBook CleanBook(LibraryBook currentBook)
        {
            var cleanBook = new LibraryBook();
            var propertiesList = typeof(LibraryBook).GetProperties();

            foreach (var property in propertiesList)
            {
                var value = property.GetValue(currentBook);

                if (value == null || value == "" || (value is IEnumerable<string> list && !list.Any()))
                    continue;

                if (value is IEnumerable<string> stringList)
                {
                    ProcessListString(cleanBook, property, stringList);
                }
                else if (value is string stringValue && !string.IsNullOrWhiteSpace(stringValue))
                {
                    property.SetValue(cleanBook, stringValue);
                }
                else if (value is IEnumerable<Form> formList)
                {
                    var cleanFormList = new List<Form>();
                    foreach (var item in formList)
                    {
                        var cleanForm = ProcessFormModel(item);
                        if (cleanForm != null &&
                            !string.IsNullOrWhiteSpace(cleanForm.ValueEN) &&
                            !string.IsNullOrWhiteSpace(cleanForm.ValueFR) &&
                            !AreDuplicateForms(cleanFormList, cleanForm))
                        {
                            cleanFormList.Add(cleanForm);
                        }
                    }

                    if (cleanFormList.Any())
                    {
                        property.SetValue(cleanBook, cleanFormList);
                    }
                }
                else if (value is IEnumerable<LibraryLink> linkList)
                {
                    var cleanLinkList = new List<LibraryLink>();
                    foreach (var item in linkList)
                    {
                        var cleanLink = ProcessLinkModel(item);
                        if (cleanLink != null &&
                            !string.IsNullOrWhiteSpace(cleanLink.Display) &&
                            !string.IsNullOrWhiteSpace(cleanLink.Url) &&
                            !AreDuplicateLinks(cleanLinkList, cleanLink))
                        {
                            cleanLinkList.Add(cleanLink);
                        }
                    }

                    if (cleanLinkList.Any())
                    {
                        property.SetValue(cleanBook, cleanLinkList);
                    }
                }
                else if (value is LibraryBookKeyword keywordList)
                {
                    property.SetValue(cleanBook, ProcessKeywordModel(keywordList));
                }
                else if (value is IEnumerable<Holding> holdingList)
                {
                    property.SetValue(cleanBook, value);
                }
            }

            return cleanBook;
        }

        public Form ProcessFormModel(Form currentSubModel)
        {
            if (currentSubModel == null)
                return null;

            var cleanForm = new Form
            {
                ValueEN = currentSubModel.ValueEN?.Trim(),
                ValueFR = currentSubModel.ValueFR?.Trim()
            };

            return cleanForm;
        }

        private bool AreDuplicateForms(List<Form> existingForms, Form newForm)
        {
            return existingForms.Any(existingForm =>
                string.Equals(existingForm.ValueEN, newForm.ValueEN, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(existingForm.ValueFR, newForm.ValueFR, StringComparison.OrdinalIgnoreCase));
        }

        public LibraryLink ProcessLinkModel(LibraryLink currentSubModel)
        {
            if (currentSubModel == null)
                return null;

            var cleanLink = new LibraryLink
            {
                Display = currentSubModel.Display?.Trim(),
                Url = currentSubModel.Url?.Trim()
            };

            return cleanLink;
        }

        private bool AreDuplicateLinks(List<LibraryLink> existingLinks, LibraryLink newLink)
        {
            return existingLinks.Any(existingForm =>
                string.Equals(existingForm.Display, newLink.Display, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(existingForm.Url, newLink.Url, StringComparison.OrdinalIgnoreCase));
        }

        public LibraryBookKeyword ProcessKeywordModel(LibraryBookKeyword currentSubModel)
        {
            var cleanSubmodelList = new LibraryBookKeyword();
            var propertiesList = typeof(LibraryBookKeyword).GetProperties();

            foreach (var property in propertiesList)
            {
                var value = property.GetValue(currentSubModel);

                if (value == null || value == "" || (value is IEnumerable<string> list && !list.Any()))
                    continue;

                if (value is IEnumerable<string> stringList)
                {
                    ProcessListString(cleanSubmodelList, property, stringList);
                }
                else
                {
                    property.SetValue(cleanSubmodelList, value);
                }
            }

            return cleanSubmodelList;
        }

        private static void ProcessListString(object model, PropertyInfo property, IEnumerable<string> stringList)
        {
            var uniqueSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (var item in stringList)
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    if (item.EndsWith('.'))
                    {
                        if (!uniqueSet.Select(x => x.TrimEnd('.')).Contains(item.TrimEnd('.')))
                            uniqueSet.Add(item.Trim());
                    }
                    else
                    {
                        if (!uniqueSet.Select(x => x.TrimEnd('.')).Contains(item))
                            uniqueSet.Add(item.Trim());
                    }
                }
            }

            var uniqueList = uniqueSet.OrderBy(x => x).ToList();

            if (uniqueList.Any())
            {
                property.SetValue(model, uniqueList);
            }
        }

    }

}
