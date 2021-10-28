using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class BuilderVEGGYPIZZA : PizzaBuilder
    {


        private PIZZA pizza;

        public BuilderVEGGYPIZZA()
        {

            this.pizza = new PIZZA();
        }


        public void buildDough()
        {
            pizza.setDough("dough persian");
        }

        public void buildTopping()
        {
            pizza.setTopping("saussage");
        }

        public void buildSauce()
        {
            pizza.setSauce("Hot");
        }


        public PIZZA getPizza()
        {
            return this.pizza;
        }

       

    }

}

