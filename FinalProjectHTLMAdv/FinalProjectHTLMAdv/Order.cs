using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{

    public class Order
    {
        public static void MakeOrder()
        {
            double TotalAmount = 0;
            bool option = true;
            
            ArrayList BillOrder = new ArrayList();
            while (option)
            {
                string product = OrderSelection.Product();
                string kindProduct = OrderSelection.KindProduct(product);
                if (product == "pizza")
                {
                    if (kindProduct == "basic")
                    {
                        AbstractFactory factory = AbstractFactory.getFactory(Kinds.BASIC);
                        Pizza pizza = factory.CreatePizza();
                        TotalAmount = TotalAmount + pizza.Price;
                        BillOrder.Add(pizza);
                    }
                    else if (kindProduct == "hawaiian")
                    {
                        AbstractFactory factory = AbstractFactory.getFactory(Kinds.HAWAIIAN);
                        Pizza pizza = factory.CreatePizza();
                        TotalAmount = TotalAmount + pizza.Price;
                        BillOrder.Add(pizza);
                    }
                    else if (kindProduct == "meatChicken")
                    {
                        AbstractFactory factory = AbstractFactory.getFactory(Kinds.MEAT_CHICKEN);
                        Pizza pizza = factory.CreatePizza();
                        TotalAmount = TotalAmount + pizza.Price;
                        BillOrder.Add(pizza);

                    }
                    else if (kindProduct == "vegeterian")
                    {
                        AbstractFactory factory = AbstractFactory.getFactory(Kinds.VEGETARIAN);
                        Pizza pizza2 = factory.CreatePizza();
                        TotalAmount = TotalAmount + pizza2.Price;
                        BillOrder.Add(pizza2);

                    }

                }
                else
                {
                    if (kindProduct == "basic" || kindProduct == "healthy")
                    {
                        AbstractFactory factory = AbstractFactory.getFactory(Kinds.BASIC);
                        Sandwich sandwich = factory.CreateSandwich(kindProduct);
                        TotalAmount = TotalAmount + sandwich.Price;
                        BillOrder.Add(sandwich);

                    }
                    else if (kindProduct == "hawaiian")
                    {
                        AbstractFactory factory = AbstractFactory.getFactory(Kinds.HAWAIIAN);
                        Sandwich sandwich = factory.CreateSandwich(kindProduct);
                        TotalAmount = TotalAmount + sandwich.Price;
                        BillOrder.Add(sandwich);

                    }
                    else if (kindProduct == "meatChicken")
                    {
                        AbstractFactory factory = AbstractFactory.getFactory(Kinds.MEAT_CHICKEN);
                        Sandwich sandwich = factory.CreateSandwich(kindProduct);
                        TotalAmount = TotalAmount + sandwich.Price;
                        BillOrder.Add(sandwich);

                    }
                    else if (kindProduct == "vegeterian")
                    {
                        AbstractFactory factory = AbstractFactory.getFactory(Kinds.VEGETARIAN);
                        Sandwich sandwich = factory.CreateSandwich(kindProduct);
                        TotalAmount = TotalAmount + sandwich.Price;
                        BillOrder.Add(sandwich);
                    }
                }

            Console.Clear();
            Console.WriteLine("Do you want to buy another product?\n\t1- SI\n\t0- NO");
            int add = int.Parse(Console.ReadLine());
                if (add == 1)
                {
                    option = true;
                }
                else if (add == 0)
                {
                    option = false;
                    Console.Clear();
                    Console.WriteLine("\t***********\tBill order Restaurant\t**********\n");
                }

            }

            for (int i = 0; i < BillOrder.Count; i++)
            {
                Console.WriteLine(BillOrder[i].ToString());
            }

            Console.WriteLine("\t\t\tTotal amount:\t\t{0:f}\t\t\tTotal products: {1}", TotalAmount, BillOrder.Count);
            Console.WriteLine("\t\t\tTotal Tax:\t\t{0:f}\n\t\t\tFinal amount:\t\t{1:f}", TotalAmount*0.19, TotalAmount + TotalAmount * 0.19);
        }
    }
}
