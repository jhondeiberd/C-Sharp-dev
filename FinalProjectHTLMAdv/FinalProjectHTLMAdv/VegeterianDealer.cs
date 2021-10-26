using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public class VegeterianDealer : AbstractFactory
    {
        public override Sandwich CreateSandwich(string kindProduct)
        {
            SandwichVeggy sandwichVeggy = new SandwichVeggy();
            SandwichOrder order = new SandwichOrder(sandwichVeggy);

            order.ConstSandwich();

            return order.GetSandwich();
        }
        
        public override Pizza CreatePizza()
        {
            PizzaVegeterian pizzaVegeterian = new PizzaVegeterian();
            PizzaOrder order = new PizzaOrder(pizzaVegeterian);

            order.ConstPizza();

            return order.GetPizza();
        }
    }
}
