using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Excercise11
{
    class Program
    {
        public static void ReadFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        public static void WriteFile(string path, string[] linesToWrite)
        {
            File.WriteAllLines(path, linesToWrite);
        }
        public static void Concatenate(string filePath1, string filePath2, string outputFilePath)
        {
            string[] lines1 = File.ReadAllLines(filePath1);
            string[] lines2 = File.ReadAllLines(filePath2);
            File.AppendAllLines(outputFilePath, lines1);
            File.AppendAllLines(outputFilePath, lines2);
        }


        static void Main(string[] args)
        {
            ReadFile("../../Program.cs");    // going twice up in the directories

            string PathFile1 = "C:/Users/isi/Desktop/file1.txt";
            string PathFile2 = "C:/Users/isi/Desktop/file2.txt";
            string PathFile3 = "C:/Users/isi/Desktop/Concatened.txt";

            string[] file1 = new string[3] { "Line 1", "Line 2", "Line 3" };
            WriteFile(PathFile1, file1);

            string[] file2 = new string[4] { "Line 4", "Line 5", "Line 6", "Line 7" };
            WriteFile(PathFile2, file2);

            Concatenate(PathFile1, PathFile2, PathFile3);
        }
    }
}


