using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilder
{
   public  class CivilEngineer
    {

       // the director class controls the algorithm that generating the final product object.
       //(the correct order of building the complex object

        private HouseBuilder houseBuilder;

        //the director MAKES THE TYPE of the building (house) (product)
        public CivilEngineer(HouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        public void constructHouse()
        {
            
            //the director controls THE ORDER OF THE STEPS OF CONSTRUCTION OF THE PRODUCT
            this.houseBuilder.buildBasement();
            this.houseBuilder.buildStructure();
            this.houseBuilder.buildRoof();
            this.houseBuilder.buildInterior();

        }

        public House getHouse()
        {
            return this.houseBuilder.getHouse();
        }

    }
}
