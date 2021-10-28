using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class WAITRESSPIZZA
    {

        private PizzaBuilder pizzaBuilder;

        public WAITRESSPIZZA(PizzaBuilder pizzaBuilder)
        {
            this.pizzaBuilder = pizzaBuilder;
        }

        public void constructPizza()
        {

            this.pizzaBuilder.buildDough();
            this.pizzaBuilder.buildSauce();
            this.pizzaBuilder.buildTopping();
        }

        public PIZZA getPizza()
        {
            return this.pizzaBuilder.getPizza();
        }

    }
}
