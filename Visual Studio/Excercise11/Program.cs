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
        class Concatened
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
                if (File.Exists(outputFilePath))
                    File.Delete(outputFilePath);
                string[] lines1 = File.ReadAllLines(filePath1);
                string[] lines2 = File.ReadAllLines(filePath2);
                File.AppendAllLines(outputFilePath, lines1);
                File.AppendAllLines(outputFilePath, lines2);
            }
        }

        public class CaesarCipher
        {
            public static string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            public static void Encrypted(string inputFilePath, int caesarShift, string outputFilePath)
            {
                if (File.Exists(outputFilePath))
                    File.Delete(outputFilePath);

                string message = File.ReadAllText(inputFilePath);
                char[] letter = message.ToCharArray();
                String messageEncripted = "";
                foreach (char simbol in letter)
                {
                    int index = GetPosChar(simbol);
                    if (index != -1)
                    {
                        int finalPosition = index - caesarShift;
                        while (finalPosition < 0)
                            finalPosition += abc.Length;
                        messageEncripted += abc[finalPosition];
                    }
                    else
                        messageEncripted += simbol;
                }
                File.WriteAllText(outputFilePath, messageEncripted);
                Console.WriteLine("File Encrypted in the path {0}", Path.GetFullPath(outputFilePath));
            }
            public static int GetPosChar(char simbol)
            {
                for (int i = 0; i < abc.Length; i++)
                {
                    if (simbol == abc[i])
                        return i;
                }
                return -1;
            }
        }
        static void Main(string[] args)
        {
            Concatened.ReadFile("../../Program.cs");    // going twice up in the directories

            string PathFile1 = "C:/Users/isi/Desktop/file1.txt";
            string PathFile2 = "C:/Users/isi/Desktop/file2.txt";
            string PathFile3 = "C:/Users/isi/Desktop/Concatened.txt";
            string PathFile4 = "C:/Users/isi/Desktop/FileMessage.txt";
            string PathFile5 = "C:/Users/isi/Desktop/FileEncripted.txt";

            string[] file1 = new string[3] { "Line 1", "Line 2", "Line 3" };
            Concatened.WriteFile(PathFile1, file1);

            string[] file2 = new string[4] { "Line 4", "Line 5", "Line 6", "Line 7" };
            Concatened.WriteFile(PathFile2, file2);

            Concatened.Concatenate(PathFile1, PathFile2, PathFile3);

            //Encripted
            Console.WriteLine("Please enter the message to encripted");
            string message = Console.ReadLine();
            string[] FileMessage = new string[1] {message};
            Concatened.WriteFile(PathFile4, FileMessage);
            Console.WriteLine("Please enter the number of caesar shift");
            int caesarShift = int.Parse(Console.ReadLine());

            CaesarCipher.Encrypted(PathFile4, caesarShift, PathFile5);
        }
    }
}


