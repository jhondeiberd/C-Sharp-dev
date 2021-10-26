using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public class PizzaVegeterian : PizzaBuilder
    {
        private Pizza pizza;

        public PizzaVegeterian()
        {
            this.pizza = new Pizza();
        }

        public void BuildName()
        {
            pizza.Name = "Vegeterian Pizza";
        }

        public void BuildCheese()
        {
            pizza.Cheese = "Cheese: American";
        }

        public void BuildSauce()
        {
            pizza.Sauce = "Sauce: Green";
        }

        public void BuildTopping()
        {
            pizza.Topping = "Especial: Spinach + Artichoke + Bell Pepper";
        }

        public void BuildPrice()
        {
            pizza.Price = 12.99;
        }

        public Pizza GetPizza()
        {
            return this.pizza;
        }

    }
}
