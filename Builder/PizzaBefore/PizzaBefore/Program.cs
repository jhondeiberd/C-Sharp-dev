using System;

namespace PizzaBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza("HawaianPizza");
            Console.WriteLine("nicolas pizza is " + pizza.getTopping() + " // " + pizza.getSauce());

            Pizza pizza2 = new Pizza("SpicyPizza");
            Console.WriteLine(" zigby is " + pizza2.getTopping());

            Pizza pizza3 = new Pizza("Special");
            Console.WriteLine("dara is " + pizza3.getTopping());
        }
    }
}
