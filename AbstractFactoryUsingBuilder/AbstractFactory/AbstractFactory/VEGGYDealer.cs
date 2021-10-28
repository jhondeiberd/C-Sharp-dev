using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class VEGGYDealer : AbstractFactory
    {

        public override PIZZA createPIZZA()
        {
            PizzaBuilder builderVEGGYPIZZA = new BuilderVEGGYPIZZA();
            WAITRESSPIZZA wai = new WAITRESSPIZZA(builderVEGGYPIZZA);
            wai.constructPizza();
            
            return wai.getPizza();
        }

        public override SANDWICH createSANDWICH()
        {
            SandwichBuilder builderVEGGYSANDWICH = new BuilderVEGGYSANDWICH();
            WAITRESSSANDWICH wai = new WAITRESSSANDWICH(builderVEGGYSANDWICH);
            wai.constructSandwich();

            return wai.getSandwich();
        }

    }
}
