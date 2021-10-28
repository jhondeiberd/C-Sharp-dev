using System;
using System.Collections.Generic;
using System.Text;


namespace AbstractFactory
{
    public class BuilderHAWAIIANPIZZA : PizzaBuilder
    {


        private PIZZA pizza;

        public BuilderHAWAIIANPIZZA()
        {

            this.pizza = new PIZZA();
        }


        public void buildDough()
        {
            pizza.setDough("dough hawaiian");
        }

        public void buildTopping()
        {
            pizza.setTopping("pine apple+ham");
        }

        public void buildSauce()
        {
            pizza.setSauce("sweet hawaiian");
        }


        public PIZZA getPizza()
        {
            return this.pizza;
        }
              
    }

}

