using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class AbstractFactory
    {

        private static VEGGYDealer VEGGYDealer = new VEGGYDealer();

        private static HAWAIIANDealer HAWAIIANDealer = new HAWAIIANDealer();


        public static AbstractFactory getFactory(Mark mark)
        {
            AbstractFactory factory = null;

            switch (mark)
            {

                case Mark.VEGGY:
                    factory =VEGGYDealer;
                    break;

                case Mark.HAWAIIAN:
                    factory =HAWAIIANDealer;
                    break;
            }

            return factory;



        }


        public abstract PIZZA createPIZZA();
        public abstract SANDWICH createSANDWICH();





    }
}
