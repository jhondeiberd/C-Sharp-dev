using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public class HawaiianDealer : AbstractFactory
    {
        public override Sandwich CreateSandwich(string kindProduct)
        {
            SandwichHawaiian hawaiian = new SandwichHawaiian();
            SandwichOrder order = new SandwichOrder(hawaiian);

            order.ConstSandwich();

            return order.GetSandwich();
        }

        public override Pizza CreatePizza()
        {
            PizzaHawaiian hawaiian = new PizzaHawaiian();
            PizzaOrder order = new PizzaOrder(hawaiian);

            order.ConstPizza();

            return order.GetPizza();

        }
    }
}
