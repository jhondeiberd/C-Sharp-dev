using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public class PizzaBasic : PizzaBuilder
    {
        private Pizza pizza;

        public PizzaBasic()
        {
            this.pizza = new Pizza();
        }

        public void BuildName()
        {
            pizza.Name = "Basic Pizza";
        }

        public void BuildCheese()
        {
            pizza.Cheese = "Cheese: Parmesan";
        }

        public void BuildSauce()
        {
            pizza.Sauce = "Sauce: Tomato";
        }

        public void BuildTopping()
        {
            pizza.Topping = "";
        }

        public void BuildPrice()
        {
            pizza.Price = 9.99;
        }

        public Pizza GetPizza()
        {
            return this.pizza;
        }
    }
}
