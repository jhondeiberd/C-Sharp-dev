using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBefore
{
    public class Pizza
    {
        private String dough = "";
        private String sauce = "";
        private String topping = "";
        private String type = "";

        //this constructor has 2 responsibilities: initialisation of the object + some decision making (business logic)
        public Pizza(String type)
        {

            //1) decides for the type of the object
            //2) initialising the attributes.
            //3) implicitly giving the order of the initialisation of the attributes.
            this.type = type;

            if (type == "HawaianPizza")
            {
                this.dough = "cross";
                this.sauce = "mild";
                this.topping = "ham+pineapple1";

            } else if( type == "SpicyPizza")
            {
                this.dough = "baked";
                this.sauce = "hot";
                this.topping = "pepporoni+salami1";

            }else if (type == "Special")
            {
                this.dough = "special baked";
                this.sauce = "sweet";
                this.topping = "meat+saucisse1";
            }
        }

        public String getTopping()
        {
            return topping;
        }

        public String getSauce()
        {
            return sauce;
        }



    }
}
