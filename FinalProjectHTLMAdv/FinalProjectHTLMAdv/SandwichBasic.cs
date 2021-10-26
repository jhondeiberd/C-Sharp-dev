using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public class SandwichBasic : SandwichBuilder
    {
        private Sandwich sandwich;
        public SandwichBasic()
        {
            this.sandwich = new Sandwich();
        }
        public void BuildName()
        {
            sandwich.Name = "Basic Sandwich";
        }
        public void BuildBread()
        {
            sandwich.Bread = "Bread: Basic white";
        }
        public void BuildSauce()
        {
            sandwich.Sauce = "Sauce: Tomato";
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
            sandwich.Topping = "";
        }
        public void BuildPrice()
        {
            sandwich.Price = 8.45;
        }
        public Sandwich GetSandwich()
        {
            return this.sandwich;
        }
    }
}
