using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise1
{
    namespace Question1
    {
        class Program
        {
            public static void Question1()
            {
                double pi = 3.14169265;
                double radius;
                Console.WriteLine("Please enter a radius");
                radius = double.Parse(Console.ReadLine());

                double per = 2 * pi * radius;
                double area = pi * radius * radius;

                Console.WriteLine("The area is: " + area + "The peremeter is: " + per);
                Console.WriteLine("Area: {0}", +pi * radius * radius);
                Console.WriteLine("Peremeter: {0}", + 2 * pi * radius);
            }
        }
    }

    namespace Question2
    {
        class Program
        {
            public static void Question2()
            {
                Console.WriteLine("Please enter a company name");
                string companyName = Console.ReadLine();

                Console.WriteLine("Please enter a company address");
                string companyAddress = Console.ReadLine();

                Console.WriteLine("Please enter a company phone number");
                string companyphoneNumber = Console.ReadLine();

                Console.WriteLine("Please enter a company fax number");
                string companyfaxNumber = Console.ReadLine();

                Console.WriteLine("Please enter a company website");
                string website = Console.ReadLine();

                Console.WriteLine("Please enter a manager name");
                string managerName = Console.ReadLine();

                Console.WriteLine("Please enter a manager surname");
                string managersurname = Console.ReadLine();

                Console.WriteLine("Please enter a manager phone number");
                string managerPhoneNumber = Console.ReadLine();

                Console.WriteLine("Company dates: " +
                                    "\n\tName: " + companyName +
                                    "\n\tAdress: " + companyAddress +
                                    "\n\tPhone number: " + companyphoneNumber +
                                    "\n\tFax number: " + companyfaxNumber +
                                    "\n\twebsite: " + website);

                Console.WriteLine("Maneger dates: " +
                                    "\n\tName: " + managerName +
                                    "\n\tSurname: " + managersurname +
                                    "\n\tPhone number: " + managerPhoneNumber);

            }
        }
    }

    namespace Question3
    {
        class Program
        {
            public static void Question3()
            {
                int n;
                int sum = 0;
                Console.Write("Please enter your integer number: ");
                n = int.Parse(Console.ReadLine());
                sum += n;
                while (n != 0)
                {
                    Console.Write("Please enter another integer number. 0 (zero) to exit: ");
                    n = int.Parse(Console.ReadLine());
                    if (n > 0)
                    {
                        sum += n;
                    }
                }
                Console.WriteLine("The sum of the your numbers is: " + sum);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Question1.Program.Question1();
            Question2.Program.Question2();
            Question3.Program.Question3();
        }
    }
}