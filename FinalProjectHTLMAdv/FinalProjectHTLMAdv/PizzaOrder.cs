using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    class PizzaOrder
    {
        private PizzaBuilder pizzaBuilder;
        public PizzaOrder (PizzaBuilder pizzaBuilder)
        {
            this.pizzaBuilder = pizzaBuilder;
        }

        public void ConstPizza()
        {
            this.pizzaBuilder.BuildCheese();
            this.pizzaBuilder.BuildSauce();
            this.pizzaBuilder.BuildTopping();
            this.pizzaBuilder.BuildPrice();
            this.pizzaBuilder.BuildName();
        }
        public Pizza GetPizza()
        {
            return this.pizzaBuilder.GetPizza();
        }

    }
}
