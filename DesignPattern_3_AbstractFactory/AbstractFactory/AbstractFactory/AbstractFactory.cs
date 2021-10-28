using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class AbstractFactory
    {

        private static VolvoDealer volvoDealer = new VolvoDealer();

        private static MercedesDealer mercedesDealer = new MercedesDealer();


        public static AbstractFactory getFactory(Mark mark)
        {
            AbstractFactory factory = null;

            switch (mark)
            {

                case Mark.MERCEDES:
                    factory = mercedesDealer;
                    break;

                case Mark.VOLVO:
                    factory =volvoDealer;
                    break;
            }

            return factory;

        }


        public abstract CAR createCAR();
        public abstract TRUCK createTRUCK();





    }
}
