using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise4
{
    namespace question1
    {
        /*1. Create a method GetMax() with two integer (int) parameters, that returns maximal of the two numbers. Write a program 
        that reads three numbers from the console and prints the biggest of them. Use the GetMax() method you just created. 
        Write a test program that validates that the methods works correctly.*/
        class program
        {
            public static int GetMax(int num1, int num2)
            {
                if (num1 > num2)
                {
                    return num1;
                }
                else
                {
                    return num2;
                }
            }
            public static void Question()
            {
                int number1, number2, number3;
                Console.Write("Enter a number 1 please: ");
                number1 = int.Parse(Console.ReadLine());
                Console.Write("Enter a number 2 please: ");
                number2 = int.Parse(Console.ReadLine());
                Console.Write("Enter a number 3 please: ");
                number3 = int.Parse(Console.ReadLine());
                if (number1 == number2 && number1 == number3)
                {
                    Console.WriteLine("The number {0}, {1}, and {2} are same", number1, number2, number3);
                }
                else
                {
                    int max = GetMax(GetMax(number1, number2), number3);
                    Console.WriteLine("The maximun number is {0}", max);
                }
                Console.ReadLine();
            }
        }
    }

    namespace question2
    {
        /*Write a method that returns the English name of the last digit of a given number. Example: for 512 prints "two"; for 1024 to "four".*/
        class program
        {
            static void NameNumber(int num)
            {
                switch (num)
                {
                    case 0:
                        Console.WriteLine("zero");
                        break;
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                }
            }
            public static void Question()
            {
                Console.Write("Enter a number please: ");
                int number = int.Parse(Console.ReadLine());
                int lastNumber = (number) % 10;
                Console.Write("The name of the last number of {0}: ({1}) is: ", number, lastNumber);
                NameNumber(lastNumber);
                Console.ReadLine();
            }
        }
    }

    namespace question3
    {
        /*	3. Write a method that finds how many times certain number can be found in a given array. Write a program 
         to test that the method works correctly.*/
        class program
        {
            static void findNumber(int[] array, int number)
            {
                int times = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (number == array[i])
                    {
                        times++;
                    }
                }
                Console.WriteLine("The number {0} is {1} in the array", number, times);
            }
            public static void Question()
            {
                int[] array = { 4, 10, 3, 5, 8, 12, 1, 4, 4 };
                Console.Write("Please enter number to find in the array: ");
                int number = int.Parse(Console.ReadLine());
                findNumber(array, number);
                Console.ReadLine();
            }
        }
    }

    namespace question4
    {
        /*4. Write a method that checks whether an element, from a certain position in an array is greater than its two neighbors. 
         Test whether the method works correctly.*/
        class program
        {
            static int MaxNumberArray(int[] arr, int num)
            {
                int indexLeft = num - 1;
                int index = num;
                int indexRight = num + 1;
                return question1.program.GetMax(question1.program.GetMax(arr[indexLeft], arr[index]), arr[indexRight]);
            }
            public static void Question()
            {
                int[] array = { 4, 10, 3, 5, 8, 12, 1, 4, 4 };
                int totalIndex = array.Length -2;
                Console.Write("Please enter the position in the array between 1 to {0}): ", totalIndex);
                int number = int.Parse(Console.ReadLine());
                while (number <= 0 || number > totalIndex)
                {
                    Console.Write("Error: the number should between 1 to {0}, please enter the position: ", totalIndex);
                    number = int.Parse(Console.ReadLine());
                }
                int maxValue = MaxNumberArray(array, number);
                Console.Write("The maximium value is {0}", maxValue);
                Console.ReadLine();
            }
        }
    }

    namespace question5
    {
        /*5. Write a method that finds the biggest element of an array. Use that method to implement sorting in ascending order.*/
        class program
        {
            public static void Question()
            {

            }
        }
    }

    namespace question6
    {
        /*6. Write a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters:
            float[] data={1.5f, 0.7f, 8.0f}
            MinMaxArray(data, ref minimum, ref maximum);
            (after that call, minimum would contain 0.7, and maximum would contain 8.0)*/	
        class program
        {
            public static void Question()
            {

            }
        }
    }

    namespace question7
    {
        /*7. Write a method named "Double" to calculate the double of an integer number, and modify the data passed as an argument. 
         It must be a "void" function and you must use the out parameter modifier.*/
        class program
        {
            public static void Question()
            {

            }
        }
    }

    namespace question8
    {
        /*Write a method named "Add" that will receives any number of integer parameters at run time and returns the sum of all those number. 
        You should use the params modifier.*/
        class program
        {
            public static void Question()
            {

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*question1.program.Question();
            question2.program.Question();
            question3.program.Question();*/
            question4.program.Question();
            question5.program.Question();
            question6.program.Question();
            question7.program.Question();
            question8.program.Question();

        }
    }
}
