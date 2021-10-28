using System;
using System.Collections.Generic;
using System.Text;

namespace Example_2_Factory_before
{
    class Rectangle : Shape   
    {

        public  override  void Draw()
        {
            Console.WriteLine("Inside Rectangle:: draw() method");
        }
    }
}
