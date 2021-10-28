using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilder
{
    public interface HouseBuilder
    {
        //this abstract Builder defines ALL THE STEPS that must be taken
        //in order to correctly create a product.

        public void buildBasement();//take 1 bread, toast it, cut it in half, put it on table
        public void buildStructure();//take 2 mush. , wash them, cut them in 5 pieces, put them on the bread
        public void buildRoof();
        public void buildInterior();
        public  House getHouse();

    }
}
