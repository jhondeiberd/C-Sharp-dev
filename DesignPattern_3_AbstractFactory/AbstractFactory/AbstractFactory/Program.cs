using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            AbstractFactory factory = AbstractFactory.getFactory(Mark.VOLVO);
            CAR car = factory.createCAR();
            TRUCK truck = factory.createTRUCK();
            car.display();
            truck.display();

            AbstractFactory factory2 = AbstractFactory.getFactory(Mark.MERCEDES);
            CAR car2 = factory2.createCAR();
            car2.display();

        }
    }
}
