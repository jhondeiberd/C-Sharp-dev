using System;
using System.Collections.Generic;
using System.Text;

namespace Example_2_Factory_after
{
    public class ShapeFactory
    {

        //string a = "ali";  there is absolutely no difference
        //String b = "ali";  String comes from .Net framwork ,
        //                   string comes from c# definition
        

        public IShape  getShape(String shapeType)
        {       

            if (shapeType == null)
            {
                return null; //return function 
            }

            //if (shapeType == "CIRCLE")
            if(String.Equals(shapeType,"CIRCLE"))
            {
                return new Circle();
            }
            else if (shapeType == "RECTANGLE")
            {
                return new Rectangle();
            }
            else if(shapeType == "SQUARE"){

                return new Square();
            }

            return null;
        }

    }
}
