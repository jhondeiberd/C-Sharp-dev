using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------------------------");
            AbstractFactory factory = AbstractFactory.getFactory(Mark.VEGGY);
            PIZZA pizza = factory.createPIZZA();
            pizza.display();
            Console.WriteLine("-----------------------");
            factory = AbstractFactory.getFactory(Mark.VEGGY);
            SANDWICH sandwich = factory.createSANDWICH();
            sandwich.display();
            Console.WriteLine("-----------------------");
            factory = AbstractFactory.getFactory(Mark.HAWAIIAN);
            pizza = factory.createPIZZA();
            pizza.display();
            Console.WriteLine("-------------------------");
            factory = AbstractFactory.getFactory(Mark.HAWAIIAN);
            sandwich = factory.createSANDWICH();
            sandwich.display();
        }
    }
}
