using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    
    public class BuilderVEGGYSANDWICH : SandwichBuilder
    {
        private SANDWICH sandwich;

        public BuilderVEGGYSANDWICH()
        {

            this.sandwich = new SANDWICH();
        }


        public void buildBread()
        {
            sandwich.setBread("bread veggy");
        }

        public void buildTopping()
        {
            sandwich.setTopping("veggy tomato mushroom");
        }

        public void buildSalade()
        {
            sandwich.setSalade("salade veggy");
        }


        public SANDWICH getSandwich()
        {
            return this.sandwich;
        }
    }
}