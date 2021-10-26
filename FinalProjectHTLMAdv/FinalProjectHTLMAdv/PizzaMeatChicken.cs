using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public class PizzaMeatChicken : PizzaBuilder
    {
        private Pizza pizza;
        public PizzaMeatChicken()
        {
            this.pizza = new Pizza();
        }
        public void BuildName()
        {
            pizza.Name = "Meat Pizza";
        }

        public void BuildCheese()
        {
            pizza.Cheese = "Cheese: Cheddar";
        }

        public void BuildSauce()
        {
            pizza.Sauce = "Sauce: Marinara sauce";
        }

        public void BuildTopping()
        {
            pizza.Topping = "Especial: Crispy chicken breast + Bacon cooked and crumbled + Egg";
        }

        public void BuildPrice()
        {
            pizza.Price = 18.99;
        }

        public Pizza GetPizza()
        {
            return this.pizza;
        }
    }
}
