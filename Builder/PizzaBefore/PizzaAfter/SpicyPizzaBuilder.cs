using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAfter
{
    public class SpicyPizzaBuilder: PizzaBuilder
    {

        public SpicyPizzaBuilder() { }

        public override void buildDough()
        {
            pizza.setDough("baked");
        }
        public override void buildSauce()
        {
            pizza.setSauce("hot");
        }
        public override void buildTopping()
        {
            pizza.setTopping("pepperoni+salami");
        }
    }
}
