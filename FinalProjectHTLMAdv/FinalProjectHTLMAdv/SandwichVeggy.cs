using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public class SandwichVeggy : SandwichBuilder
    {
        private Sandwich sandwich;
        public SandwichVeggy()
        {
            this.sandwich = new Sandwich();
        }
        public void BuildName()
        {
            sandwich.Name = "Vegeterian Sandwich";
        }

        public void BuildBread()
        {
            sandwich.Bread = "Bread: Multi-grain Flatbread";
        }

        public void BuildSauce()
        {
            sandwich.Sauce = "Sauce: Chipotle Mayonnaise";
        }

        public void BuildTomato()
        {
            sandwich.Tomato = "Tomato: Red Tomato";
        }
        public void BuildOnion()
        {
            sandwich.Onion = "Onion: Red Onions";
        }
        public void BuildTopping()
        {
            sandwich.Topping = "Especial: Cucumbers + Green Peppers + Lettuce + Spinach";
        }

        public void BuildPrice()
        {
            sandwich.Price = 11.99;
        }

        public Sandwich GetSandwich()
        {
            return this.sandwich;
        }
    }
}
