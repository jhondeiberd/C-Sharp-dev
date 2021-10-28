using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAfter
{
    public abstract class PizzaBuilder
    {
        public Pizza pizza;

        public Pizza getPizza()
        {
            return pizza;
        }
        public void createnewPizzaProduct()
        {
            pizza = new Pizza();
        }

        public abstract void buildDough();
        public abstract void buildSauce();
        public abstract void buildTopping();
    }
}
