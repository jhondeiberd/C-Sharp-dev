using System;
using System.Collections.Generic;
using System.Text;

namespace Example_1_Factory_After
{
    class Person
    {

        public int Id { get; set; }
        public string Name { get; set; }

        //public Person() { }  //if the compilier doesnt find a constructor
        //it will create one for us

        public void Display()
        {
            Console.WriteLine(Id + " " + Name);
        }
    }
}
