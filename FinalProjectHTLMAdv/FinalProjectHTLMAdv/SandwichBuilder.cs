using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public interface SandwichBuilder
    {
        void BuildName();
        void BuildBread();
        void BuildSauce();
        void BuildTomato();
        void BuildOnion();
        void BuildTopping();
        void BuildPrice();
        Sandwich GetSandwich();
    }
}
