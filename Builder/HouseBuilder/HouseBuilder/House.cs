using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilder
{
    public class House : HousePlan
    {   //products are the resulting objects.We could call it the base product.

        public String basement;
        public String structure;
        public String roof;
        public String interior;

        
        //this is replacing a part of the constructor in order to make one piece(object) of
        //the complex object which is the house.
        public void setBasement(String basement)
        {
            this.basement = basement;
        }
        public void setStructure(String structure)
        {
            this.structure=structure;
        }
        public void setRoof(String roof)
        {
            this.roof = roof;
        }
        public void setInterior(String interior)
        {
            this.interior = interior;
        }
    }
}
