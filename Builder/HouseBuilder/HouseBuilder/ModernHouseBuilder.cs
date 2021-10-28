using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilder
{
    public class ModernHouseBuilder : HouseBuilder
    {

        //concrete builder: this class contains the functionality to create a particular complex product.

        private House house;

        public ModernHouseBuilder()
        {

            this.house = new House();
        }



        public void buildBasement()
        {
            house.setBasement("Cinema maison");
        }

        public void buildStructure()
        {
            house.setStructure("Wooden");
        }

        public void buildInterior()
        {
            house.setInterior("Granit");
        }
        public void buildRoof()
        {
            house.setRoof("30 feet medieval European");
        }

        public House getHouse()
        {
            return this.house;
        }

    }
}
