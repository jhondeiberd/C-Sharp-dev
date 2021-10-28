using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface SandwichBuilder
    {

        public void buildBread();
        public void buildTopping();
        public void buildSalade();
        public SANDWICH getSandwich();

       

    }
}