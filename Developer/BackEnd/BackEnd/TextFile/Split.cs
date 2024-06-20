using System.Collections.Generic;
using System.Linq;

namespace TextFiles
{
    public class Split
    {
        //Split variables with differents name in a folder  

        public static IEnumerable<object> GetDateStringFromWMSzip()
        {
            string sfiles = "metacoll.updates.D20240613.T213016.WebsiteDUMP.3.mrc,metacoll.updates.D20240613.T213016.WebsiteDUMP.2.mrc";
            var test11 = GetDateStringFromWMSzipFile(sfiles.Split(',')[0]);

            var f3 = sfiles.Split(',')
                .Select(x => new
                {
                    dateGroup = GetDateStringFromWMSzipFile(x),
                    countGroup = x.Count()
                })
                .Where(x => x.countGroup > 2);
            return f3;
        }

        public static string GetDateStringFromWMSzipFile(string Filename)
        {
            return Filename.Split('.')[2];
        }
    }

}
