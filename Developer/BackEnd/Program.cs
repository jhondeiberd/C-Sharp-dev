using System;
using TextFiles;
using static System.Net.Mime.MediaTypeNames;

namespace BackEnd
{
    public class Program
    {
        static void Main()
        {
            var split = Split.GetDateStringFromWMSzip();
            Application.Run(new Split());

        }

    }
}