using System;
using System.Collections.Generic;
using System.Text;

namespace Example_2_Factory_before
{
    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Inside Square::draw() method");
        }
    }
}
