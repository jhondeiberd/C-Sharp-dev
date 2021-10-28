using System;
using System.Collections.Generic;
using System.Text;

namespace Example_1_Factory_before
{
    class Person
    {
        private static int Id { get; set; } = 121;
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
            Id = Id++;
        }

        public void Display()
        {
            Console.WriteLine(Id + " " + Name); //type coercion
        }
    }
}