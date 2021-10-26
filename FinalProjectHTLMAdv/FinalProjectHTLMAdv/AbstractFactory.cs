using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public abstract class AbstractFactory
    {
        private static HawaiianDealer hawaiian = new HawaiianDealer();

        private static VegeterianDealer vegeterian = new VegeterianDealer();
        
        private static MeatChichekDealer meatChicken = new MeatChichekDealer();
        
        private static BasicDealer basic = new BasicDealer();

        public static AbstractFactory getFactory(Kinds mark)
        {
            AbstractFactory factory = null;

            switch (mark)
            {

                case Kinds.HAWAIIAN:
                    factory = hawaiian;
                    break;

                case Kinds.VEGETARIAN:
                    factory = vegeterian;
                    break;

                case Kinds.MEAT_CHICKEN:
                    factory = meatChicken;
                    break;

                case Kinds.BASIC:
                    factory = basic;
                    break;
            }
            return factory;
        }

        public abstract Sandwich CreateSandwich(string kindProduct);
        public abstract Pizza CreatePizza();

    }
}
