using System;
using System.Collections.Generic;
using System.Text;

namespace Example_2_Factory_after
{
    public class Circle : IShape 
    {
        public void Draw()
        {
            Console.WriteLine("Insdie Circle::draw() method.");
        }
    }
}
