using System.Collections.Generic;
using System.IO;

namespace TextFiles
{
    public class ListFiles
    {
        //Get all the files in folder
        public static IEnumerable<object> GetFiles()
        {
            string path1 = @"C:\SoftwareData\CCA.LSP.API\";
            IEnumerable<string> files = Directory.EnumerateFiles(path1, "*.mrc").ToList();
            return files;
        }
    }

}