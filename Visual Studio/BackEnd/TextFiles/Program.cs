using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.TextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sfiles = "metacoll.updates.D20240613.T213016.WebsiteDUMP.3.mrc,metacoll.updates.D20240613.T213016.WebsiteDUMP.2.mrc";

            var f3 = sfiles.Split(',')
                .Select(x => new
                {
                    dateGroup = GetDateStringFromWMSzipFile(x),
                    countGroup = x.Count()
                })
                .Where(x => x.countGroup > 2);

            var test11 = GetDateStringFromWMSzipFile(sfiles.Split(',')[0]);

            static string GetDateStringFromWMSzipFile(string Filename)
            {
                return Filename.Split('.')[3];
            }

        }
    }
}
