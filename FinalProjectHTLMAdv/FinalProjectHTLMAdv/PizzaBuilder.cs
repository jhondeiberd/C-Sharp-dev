using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public interface PizzaBuilder
    {
        void BuildCheese();
        void BuildSauce();
        void BuildTopping();
        void BuildPrice();
        void BuildName();
        Pizza GetPizza();
    }
}
