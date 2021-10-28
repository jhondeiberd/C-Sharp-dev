using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class VolvoDealer : AbstractFactory
    {

        public override CAR createCAR()
        {
            return new VolvoCAR();
        }

        public override TRUCK createTRUCK()
        {
            return new VolvoTRUCK();
        }

    }
}
