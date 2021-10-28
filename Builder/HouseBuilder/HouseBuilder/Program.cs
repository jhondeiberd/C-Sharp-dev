using System;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            HouseBuilder persianHouseBuilder = new PersianHouseBuilder();
            CivilEngineer engineer = new CivilEngineer(persianHouseBuilder);
    
            engineer.constructHouse();

            Console.WriteLine("Builder constructed structure : " + engineer.getHouse().structure);
            Console.WriteLine("Builder constructed roof : " + engineer.getHouse().roof);
            Console.WriteLine("Builder constructed interior : " + engineer.getHouse().interior);
            Console.WriteLine("Builder constructed basement: " + engineer.getHouse().basement);

            Console.WriteLine("------------------------------------------------------------");

            HouseBuilder modernBuilder = new ModernHouseBuilder();
            CivilEngineer engineer2 = new CivilEngineer(modernBuilder);

            engineer2.constructHouse();

            Console.WriteLine("Builder constructed structure : " + engineer2.getHouse().structure);
            Console.WriteLine("Builder constructed roof : " + engineer2.getHouse().roof);
            Console.WriteLine("Builder constructed interior : " + engineer2.getHouse().interior);
            Console.WriteLine("Builder constructed basement: " + engineer2.getHouse().basement);




        }
    }
}
