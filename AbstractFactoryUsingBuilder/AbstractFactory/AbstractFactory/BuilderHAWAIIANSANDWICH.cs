using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class BuilderHAWAIIANSANDWICH : SandwichBuilder {
        private SANDWICH sandwich;

        public BuilderHAWAIIANSANDWICH()
        {

            this.sandwich = new SANDWICH();
        }


        public void buildBread()
        {
            sandwich.setBread("bread hawaiian");
        }

        public void buildTopping()
        {
            sandwich.setTopping("pine apple+ham");
        }

        public void buildSalade()
        {
            sandwich.setSalade("salade hawaiian");
        }


        public SANDWICH getSandwich()
        {
            return this.sandwich;
        }
    }
    
}
