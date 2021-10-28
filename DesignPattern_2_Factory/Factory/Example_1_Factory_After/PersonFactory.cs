using System;
using System.Collections.Generic;
using System.Text;

namespace Example_1_Factory_After
{
    class PersonFactory
    {
        private int id = 100;
        //public PersonFactory() { } this is a reminder of the implicit MANDATORY CONSTRUCTOR
        public Person CreatePerson(string name)
        {
            return new Person { Id = id++, Name = name };
        }
    }
}
