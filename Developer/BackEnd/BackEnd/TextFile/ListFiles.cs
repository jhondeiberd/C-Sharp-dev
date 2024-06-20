using System.Collections.Generic;
using System.IO;

string mrkpath = @"C:\SoftwareData\CCA.LSP.API\";

List<string> test11 = Directory.EnumerateFiles(mrkpath, "*.mrc").ToList();