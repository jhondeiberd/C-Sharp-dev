using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAfter
{
   public  class Waiter
    {
        private PizzaBuilder pizzaBuilder;

        //deciding for the type.
        public void setPizzaBuilder(PizzaBuilder pb)
        {
            pizzaBuilder = pb;
        }

        public Pizza getPizza()
        {
            return pizzaBuilder.getPizza();
        }
        //giving the order of creation of steps
        public void constructPizza()
        {
            pizzaBuilder.createnewPizzaProduct();
            pizzaBuilder.buildDough();
            pizzaBuilder.buildSauce();
            pizzaBuilder.buildTopping();
        }

    }
}
