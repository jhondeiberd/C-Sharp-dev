using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public class SandwichHawaiian : SandwichBuilder
    {
        private Sandwich sandwich;
        public SandwichHawaiian()
        {
            this.sandwich = new Sandwich();
        }
        public void BuildName()
        {
            sandwich.Name = "Hawaiian Sandwich";
        }
        public void BuildBread()
        {
            sandwich.Bread = "Bread: 9-Grain Wheat";
        }
        public void BuildSauce()
        {
            sandwich.Sauce = "Sauce: Honey Mustard Mayonnaise";
        }
        public void BuildTomato()
        {
            sandwich.Tomato = "Tomato: Green Tomato";
        }
        public void BuildOnion()
        {
            sandwich.Onion = "Onion: Sweet Onions";
        }
        public void BuildTopping()
        {
            sandwich.Topping = "Especial: slices pineapple + slices ham";
        }
        public void BuildPrice()
        {
            sandwich.Price = 13.55;
        }
        public Sandwich GetSandwich()
        {
            return this.sandwich;
        }
    }
}
