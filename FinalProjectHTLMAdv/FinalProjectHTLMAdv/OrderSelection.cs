using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    class OrderSelection
    {
        public static string Product()
        {
            Console.Clear();
            Console.WriteLine("*******\tRESTAURANT MENU\t*******");
            string product = "";
            bool option = true;
            Console.WriteLine("\t1- Pizza");
            Console.WriteLine("\t2- Sandwich");
            Console.WriteLine("Choose a product: ");

            while (option)
            {
                try
                {
                    option = false;
                    int numberOrder = int.Parse(Console.ReadLine());
                    option = true;
                    while (option)
                    {
                        if (numberOrder == 1)
                        {
                            product = "pizza";
                            option = false;

                        }
                        else if (numberOrder == 2)
                        {
                            product = "sandwich";
                            option = false;

                        }
                        else
                        {
                            Console.WriteLine("Error: please choose a correct option of the Menu");
                            numberOrder = int.Parse(Console.ReadLine());
                            option = true;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: please enter only numbers");
                    option = true;
                }
            }
            return product;
        }
        public static string KindProduct(string product)
        {
            string nameKind = "";
            bool option = true;
            if (product == "pizza")
            {
                option = false;
                Console.WriteLine("Choose a kind of pizza do you like: ");
                Console.WriteLine("\t1- Basic Pizza");
                Console.WriteLine("\t2- Hawaiian Pizza");
                Console.WriteLine("\t3- Meat Pizza");
                Console.WriteLine("\t4- Vegeterian Pizza");
                int kind = int.Parse(Console.ReadLine());
                option = true;
                while (option)
                {
                    try
                    {
                        while (option)
                        {
                            if (kind == 1)
                            {
                                nameKind = "basic";
                                option = false;
                            }
                            else if (kind == 2)
                            {
                                nameKind = "hawaiian";
                                option = false;

                            }
                            else if (kind == 3)
                            {
                                nameKind = "meatChicken";
                                option = false;

                            }
                            else if (kind == 4)
                            {
                                nameKind = "vegeterian";
                                option = false;
                            }
                            else
                            {
                                Console.WriteLine("Error: please choose a correct option of the pizza");
                                kind = int.Parse(Console.ReadLine());
                                option = true;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error: please enter only numbers");
                        option = true;
                    }
                }
            }
            else if (product == "sandwich")
            {
                option = false;
                Console.WriteLine("Choose a kind of sandwich do you like: ");
                Console.WriteLine("\t1- Basic Sandwich");
                Console.WriteLine("\t2- Hawaiian Sandwich");
                Console.WriteLine("\t3- Healthy Sandwich");
                Console.WriteLine("\t4- Chicken Sandwich");
                Console.WriteLine("\t5- Vegeterian Sandwich");
                int kind = int.Parse(Console.ReadLine());
                option = true;
                while (option)
                {
                    try
                    {
                        while (option)
                        {
                            if (kind == 1)
                            {
                                nameKind = "basic";
                                option = false;
                            }
                            else if (kind == 2)
                            {
                                nameKind = "hawaiian";
                                option = false;

                            }
                            else if (kind == 3)
                            {
                                nameKind = "healthy";
                                option = false;

                            }
                            else if (kind == 4)
                            {
                                nameKind = "meatChicken";
                                option = false;

                            }
                            else if (kind == 5)
                            {
                                nameKind = "vegeterian";
                                option = false;
                            }
                            else
                            {
                                Console.WriteLine("Error: please choose a correct option of the pizza");
                                kind = int.Parse(Console.ReadLine());
                                option = true;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error: please enter only numbers");
                        option = true;
                    }
                }
            }
            return nameKind;
        }
    }
}
