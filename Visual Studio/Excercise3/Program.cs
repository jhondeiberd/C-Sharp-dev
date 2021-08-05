using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3
{
    /*Write a method to find a value in an array.
    The method returns the index of the searched value in the array.
    Manage the case when the given value is not found.*/
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 10, 3, 5, 8, 12, 1 };
            Console.Write("Please enter number to find in the array: ");
            int number = int.Parse(Console.ReadLine());
            findNumber(array, number);
            Console.ReadLine();
        }

        static void findNumber(int[] array, int number)
        {
            bool found = false;
            int? position = null;
            for (int i = 0; i < array.Length; i++)
            {
                if (number == array[i])
                {
                    found = true;
                    position = i;
                }
            }
            if (found is true)
            {
                Console.Write("\nYour number {0} is in the array with index: {1}\n", number, position);
            }
            else
            {
                Console.Write("\nYour number {0} is not found in the array\n", number);
            }
        }
    }
}