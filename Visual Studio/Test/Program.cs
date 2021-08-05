using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void PrintNameAndAge(string name, int age)
        {
            Console.WriteLine("name:{0}, age: {1}", name, age);
        }

        static void PrintNameSchoolCity(string name, string school = "ISI", string city = "Montreal")
        {
            Console.WriteLine("name:{0}, school:{1}, city:{2}", name, school, city);
        }


        static void Main(string[] args)
        {
            PrintNameAndAge("toto", 12);
            PrintNameAndAge(age: 25, name: "titi");
            //Console.ReadLine();

            PrintNameSchoolCity("toto");
            PrintNameSchoolCity("toto", "UQAM");
            PrintNameSchoolCity("toto", city: "Toronto");
            PrintNameSchoolCity("Toronto", "toto");
            PrintNameSchoolCity("toto", city: "Toronto", school: "Toronto University");
            PrintNameSchoolCity("toto");
            Console.ReadLine();


        }
    }
}
