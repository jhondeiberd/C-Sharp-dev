using System;

namespace PizzaAfter
{
    class Program
    {
        static void Main(string[] args)
        {

            Waiter waiter = new Waiter();
            PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
            PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();

            waiter.setPizzaBuilder(hawaiianPizzaBuilder);
            waiter.constructPizza();
            Pizza pizza = waiter.getPizza();
            Console.WriteLine("my pizza is " + pizza.getTopping());


            waiter.setPizzaBuilder(spicyPizzaBuilder);
            waiter.constructPizza();




            Pizza pizza2 = waiter.getPizza();
            Console.WriteLine("my pizza is " + pizza2.getTopping());
        }
    }
}
