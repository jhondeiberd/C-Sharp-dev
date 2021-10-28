using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAfter
{
    public class HawaiianPizzaBuilder : PizzaBuilder
    {
        public HawaiianPizzaBuilder() { }

        public override void buildDough()
        {
            pizza.setDough("cross");
        }
        public override void buildSauce()
        {
            pizza.setSauce("mild");
        }
        public override void buildTopping()
        {
            pizza.setTopping("ham+pineapple2");
        }
    }
}
