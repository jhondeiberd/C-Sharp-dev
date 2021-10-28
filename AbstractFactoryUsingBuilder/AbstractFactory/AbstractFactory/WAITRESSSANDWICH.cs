using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class WAITRESSSANDWICH
    {


        private SandwichBuilder sandwichBuilder;

        public WAITRESSSANDWICH(SandwichBuilder sandwichBuilder)
        {
            this.sandwichBuilder = sandwichBuilder;
        }

        public void constructSandwich()
        {

            this.sandwichBuilder.buildBread();
            this.sandwichBuilder.buildSalade();
            this.sandwichBuilder.buildTopping();
        }

        public SANDWICH getSandwich()
        {
            return this.sandwichBuilder.getSandwich();
        }

    }
}
