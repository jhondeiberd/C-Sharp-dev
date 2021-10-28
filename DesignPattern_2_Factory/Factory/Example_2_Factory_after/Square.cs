using System;
using System.Collections.Generic;
using System.Text;

namespace Example_2_Factory_after
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::Draw() method");
        }
    }
}
