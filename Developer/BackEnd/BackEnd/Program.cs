using static System.Net.Mime.MediaTypeNames;
using TextFiles;

namespace BackEnd
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello!");
            var split = Split.GetDateStringFromWMSzip();
            var files = ListFiles.GetFiles();
    
        }
    }
}