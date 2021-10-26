using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public class SandwichMeatChicken : SandwichBuilder
    {
        private Sandwich sandwich;
        public SandwichMeatChicken()
        {
            this.sandwich = new Sandwich();
        }
        public void BuildName()
        {
            sandwich.Name = "Chicken Sandwich";
        }
        public void BuildBread()
        {
            sandwich.Bread = "Bread: Italian herbs";
        }
        public void BuildSauce()
        {
            sandwich.Sauce = "Sauce: Smoky honey mustard sauce";
        }
        public void BuildTomato()
        {
            sandwich.Tomato = "Tomato: Green and Red Tomato";
        }
        public void BuildOnion()
        {
            sandwich.Onion = "Onion: Sweet Onions";
        }
        public void BuildTopping()
        {
            sandwich.Topping = "Especial: Shaved steak + bacon + slices ham";
        }
        public void BuildPrice()
        {
            sandwich.Price = 17.99;
        }
        public Sandwich GetSandwich()
        {
            return this.sandwich;
        }
    }
}
