using System;

namespace Example_1_Factory_before
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person("ali"); //coupling //new keyword in main is forbidden
            p1.Display();

            //we want to have one class one responsibility (robust)
            //we want to have one method(function) one job or responsibility

            var p2 = new Person("Sara");
            p2.Display();
        }
    }
}
