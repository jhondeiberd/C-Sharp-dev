using System;
using System.Collections.Generic;
using System.Text;

namespace Example_2_Factory_before
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Inside Circle::draw method");
        }
    }
}
