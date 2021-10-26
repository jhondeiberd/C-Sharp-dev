using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public class MeatChichekDealer: AbstractFactory
    {
        public override Sandwich CreateSandwich(string kindProduct)
        {
            SandwichMeatChicken meatChicken = new SandwichMeatChicken();
            SandwichOrder order = new SandwichOrder(meatChicken);

            order.ConstSandwich();

            return order.GetSandwich();
        }

        public override Pizza CreatePizza()
        {
            PizzaMeatChicken meatChicken = new PizzaMeatChicken();
            PizzaOrder order = new PizzaOrder(meatChicken);

            order.ConstPizza();

            return order.GetPizza();
        }
    }
}
