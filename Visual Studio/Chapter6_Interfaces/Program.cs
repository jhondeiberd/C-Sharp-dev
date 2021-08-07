using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Interfaces
{
    class Laptop
    {

    }
    class Student
    {
        public void WorkOnLaptod(Laptop aLaptop)
        {
            Console.WriteLine("Laptop is charching...");
        }
        public void ChargeLaptod(Laptop aLaptop)
        {
            aLaptop.Charge();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}



