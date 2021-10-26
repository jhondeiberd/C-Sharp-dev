using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public class SandwichHealthy : SandwichBuilder
    {
        private Sandwich sandwich;
        public SandwichHealthy()
        {
            this.sandwich = new Sandwich();
        }
        public void BuildName()
        {
            sandwich.Name = "Healthy Sandwich";
        }
        public void BuildBread()
        {
            sandwich.Bread = "Bread: 9-Grain Wheat";
        }
        public void BuildSauce()
        {
            sandwich.Sauce = "Sauce: House Sandwich Sauce";
        }
        public void BuildTomato()
        {
            sandwich.Tomato = "Tomato: Green and red Tomato";
        }
        public void BuildOnion()
        {
            sandwich.Onion = "Onion: Red Onions";
        }
        public void BuildTopping()
        {
            sandwich.Topping = "Especial: Tuna blended";
        }
        public void BuildPrice()
        {
            sandwich.Price = 14.85;
        }
        public Sandwich GetSandwich()
        {
            return this.sandwich;
        }
    }
}
