using System;

namespace Example_1_Factory_After
{
    class Program
    {
        static void Main(string[] args)
        {
            var pf = new PersonFactory();

            var p1 = pf.CreatePerson("ali");
            var p2 = pf.CreatePerson("sarah");
            var p3 = pf.CreatePerson("dara");
            
            

            p1.Display();
            p2.Display();
            p3.Display();

        }
    }
}
