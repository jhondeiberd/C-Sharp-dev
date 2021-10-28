using System;

namespace Example_2_Factory_after
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            //get an object of type Circle and calling its Draw method
            IShape shape1 = shapeFactory.getShape("CIRCLE"); //new Circle()
            shape1.Draw();

            IShape shape2 = shapeFactory.getShape("RECTANGLE"); //new Rectangle()
            shape2.Draw();

            IShape shape3 = shapeFactory.getShape("SQUARE"); //new Square()
            shape3.Draw();
        }
    }
}
