using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public class PizzaHawaiian : PizzaBuilder
    {
        private Pizza pizza;

        public PizzaHawaiian()
        {
            this.pizza = new Pizza();
        }

        public void BuildName()
        {
            pizza.Name = "Hawaiian Pizza";
        }

        public void BuildCheese()
        {
            pizza.Cheese = "Cheese: Mozzarella";
        }

        public void BuildSauce()
        {
            pizza.Sauce = "Sauce: Tomato and pineapple";
        }

        public void BuildTopping()
        {
            pizza.Topping = "Especial: Pineapple + Bacon cooked and crumbled + Ham";
        }

        public void BuildPrice()
        {
            pizza.Price = 15.99;
        }

        public Pizza GetPizza()
        {
            return this.pizza;
        }
    }
}
