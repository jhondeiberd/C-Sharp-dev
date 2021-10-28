using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
   public  class MercedesDealer : AbstractFactory
    {

        public override CAR createCAR()
        {
            return new MercedesCAR();
        }



        public override TRUCK createTRUCK()
        {
            return new MercedesTRUCK();
        }


    }
}
