using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Customer
    {
        // Auto-Impl Properties
        public double TotalPurchases { get; set; }
        public string Name { get; set; }
        public int CustomerID { get; set; }
        ~Customer()
        {
            Console.WriteLine("destroying Customer object...");
        }

        public void OpenConection()
        {
            //
        }
        public void CloseConection()
        {
            //
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer aCustomer = new Customer()
            {
                Name = "toto",
                CustomerID = 123
            };

            aCustomer.OpenConection();
            aCustomer.CloseConection();
            aCustomer = null;
            Console.ReadLine();
        }
    }

}
