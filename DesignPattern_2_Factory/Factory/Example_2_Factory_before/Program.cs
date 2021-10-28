using System;

namespace Example_2_Factory_before
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Shape  shape1 = new Circle();
            shape1.Draw();

            Shape shape2 = new Rectangle();
            shape2.Draw();

            Shape shape3 = new Square();
            shape3.Draw();
        }
    }
}
