using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilder
{
    public interface HousePlan
    {

        public void setBasement(String basement);
        public void setStructure(String structure);
        public void setInterior(String interior);
        public void setRoof(String roof);
    }
}
