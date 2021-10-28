using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilder
{
    public class PersianHouseBuilder : HouseBuilder
    {
        //concrete builder: this class contains the functionality to create a particular complex product.

        private House house;

        public PersianHouseBuilder()
        {
            
            this.house = new House();
        }

        
        public void buildBasement()
        {
            house.setBasement("Persian Carpet Wall to Wall");
        }

        public void buildStructure()
        {
            house.setStructure("Bricks");
        }

        public void buildInterior()
        {
            house.setInterior("Sheherzade");
        }
        public void buildRoof()
        {
            house.setRoof("Islamic colorfull Dome");
        }

        public House getHouse()
        {
            return this.house;
        }

    }
}
