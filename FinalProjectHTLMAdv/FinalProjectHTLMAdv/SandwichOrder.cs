using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    class SandwichOrder
    {
        private SandwichBuilder sandwichBuilder;
        public SandwichOrder (SandwichBuilder sandwichBuilder)
        {
            this.sandwichBuilder = sandwichBuilder;
        }

        public void ConstSandwich()
        {
            this.sandwichBuilder.BuildName();
            this.sandwichBuilder.BuildBread();
            this.sandwichBuilder.BuildSauce();
            this.sandwichBuilder.BuildTomato();
            this.sandwichBuilder.BuildOnion();
            this.sandwichBuilder.BuildTopping();
            this.sandwichBuilder.BuildPrice();
        }

        public void BuildBread()
        {
            this.sandwichBuilder.BuildBread();
        }

        public void BuildSauce()
        {
            this.sandwichBuilder.BuildSauce();
        }

        public void BuildTomato()
        {
            this.sandwichBuilder.BuildTomato();
        }

        public void BuildOnion()
        {
            this.sandwichBuilder.BuildOnion();
        }

        public void BuildTopping()
        {
            this.sandwichBuilder.BuildTopping();
        }

        public void BuildPrice()
        {
            this.sandwichBuilder.BuildPrice();
        }

        public Sandwich GetSandwich()
        {
            return this.sandwichBuilder.GetSandwich();
        }


    }
}
