using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface PizzaBuilder
    {


        public void buildDough();
        public void buildTopping();
        public void buildSauce();
        public PIZZA getPizza();

    }
}
