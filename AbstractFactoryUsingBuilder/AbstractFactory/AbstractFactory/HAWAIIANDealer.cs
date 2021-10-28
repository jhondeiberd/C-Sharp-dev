using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class HAWAIIANDealer : AbstractFactory
    {

        public override PIZZA createPIZZA()
        {
            PizzaBuilder builderHAWAIIANPIZZA = new BuilderHAWAIIANPIZZA();
            WAITRESSPIZZA wai = new WAITRESSPIZZA(builderHAWAIIANPIZZA);
            wai.constructPizza();

            return wai.getPizza();
        }

        public override SANDWICH createSANDWICH()
        {
            SandwichBuilder builderHAWAIIANSANDWICH = new BuilderVEGGYSANDWICH();
            WAITRESSSANDWICH wai = new WAITRESSSANDWICH(builderHAWAIIANSANDWICH);
            wai.constructSandwich();

            return wai.getSandwich();
        }

    }
}
