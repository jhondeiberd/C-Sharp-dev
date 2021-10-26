using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public class BasicDealer : AbstractFactory
    {
        public override Sandwich CreateSandwich(string kindProduct)
        {
            if (kindProduct == "basic")
            {
                SandwichBasic basic = new SandwichBasic();
                SandwichOrder order = new SandwichOrder(basic);

                order.ConstSandwich();

                return order.GetSandwich();

            } 
            else
            {
                SandwichHealthy healthy = new SandwichHealthy();
                SandwichOrder order = new SandwichOrder(healthy);

                order.ConstSandwich();

                return order.GetSandwich();
            }
        }

        public override Pizza CreatePizza()
        {
            PizzaBasic basic = new PizzaBasic();
            PizzaOrder order = new PizzaOrder(basic);

            order.ConstPizza();

            return order.GetPizza();
        }
    }
}
