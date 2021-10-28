using System;
using System.Collections.Generic;
using System.Text;

namespace Example_2_Factory_after
{
    public class Rectangle : IShape  //class Rectangle implements IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle:: draw() method");
        }
    }
}
