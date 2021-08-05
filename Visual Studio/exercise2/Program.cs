using System;

namespace exercise2
{
    namespace Types_variables
    {
        class Program
        {
            public static void Question1()
            /*1-Declare several variables by selecting for each one of them the most appropriate 
             of the types sbyte, byte, short, ushort, int, uint, long and ulong in order to assign
             them the following values: 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000;
             112; -44; -1,000,000; 1990; 123456789123456789.*/
            {
                Console.WriteLine("Types_variables - Question 1");
                ushort var1 = 52130;
                sbyte var2 = -115;
                int var3 = 4825932;
                sbyte var4 = 97;
                short var5 = -10000;
                short var6 = 20000;
                byte var7 = 224;
                int var8 = 970700000;
                byte var9 = 112;
                sbyte var10 = -44;
                int var11 = -1000000;
                short var12 = 1990;
                long var13 = 123456789123456789;

                Console.WriteLine(
                      "\nValues: 52,130 variable: " + var1 
                    + "\nValues: -115 variable: " + var2 
                    + "\nValues: 4825932 variable: " + var3 
                    + "\nValues: 97 variable: " + var4 
                    + "\nValues: -10000 variable: " + var5 
                    + "\nValues: 20000 variable: " + var6 
                    + "\nValues: 224 variable: " + var7 
                    + "\nValues: 970700000 variable: " + var8
                    + "\nValues: 112 variable: " + var9
                    + "\nValues: -44 variable: " + var10
                    + "\nValues: -1,000,000 variable: " + var11
                    + "\nValues: 1990 variable: " + var12
                    + "\nValues: 123456789123456789 variable: " + var13
                    );
            }

            public static void Question2()
            /*Declare a variable isMale of type bool and assign a value to it depending on your gender.*/
            {
                Console.WriteLine("\nTypes_variables - Question 2");
                bool isMale = false;
                Console.WriteLine(isMale ? "Is Male" : "Is Female");
            }
            public static void Question3()
            /*Declare two variables of type string with values "Hello" and "World". Declare a variable of type object. Assign the value 
            obtained of concatenation of the two string variables (add space if necessary) to this variable. Print the variable of type object.*/
            {
                Console.WriteLine("\nTypes_variables - Question 3");
                string variable1 = "Hello";
                string variable2 = "World";
                object concatenation = variable1 + ' ' + variable2;
                Console.WriteLine(concatenation);
            }
        }
    }

    namespace FlowControl
    {
        class Program
        {
            public static void Question1()
            {
                int result;
                Console.Write("Please enter a score between 1 to 9: ");
                int score = int.Parse(Console.ReadLine());
                switch (score)
                {
                    case 1:
                    case 2:
                    case 3:
                        result = score * 10;
                        Console.WriteLine("The result is: " + result);
                        break;
                    case 4:
                    case 5:
                    case 6:
                        result = score * 100;
                        Console.WriteLine("The result is: " + result);
                        break;
                    case 7:
                    case 8:
                    case 9:
                        result = score * 1000;
                        Console.WriteLine("The result is: " + result);
                        break;
                    default:
                        Console.WriteLine("Error: The score is not in the allowed range");
                        break;
                }
            }
        }
    }

    namespace Enumerations
    {
        class program
        {
            public enum status { ONLINE, OFFLINE, BUSY };
            public class Chat
            {
                public string username;
                public string usergender;
                public int userage;
                public string email;
                public status chatStatus;

                public Chat(string username, string usergender, int userage, string email, status chatStatus)
                {
                    this.username = username;
                    this.usergender = usergender;
                    this.userage = userage;
                    this.email = email;
                    this.chatStatus = chatStatus;
                }
            }
            public static void Questions()
            {
                Chat chat1 = new Chat("JhonDeiber", "Male", 40, "jhondeiberd@gmail.com", status.BUSY);
                Chat chat2 = new Chat("Jhon", "Male", 40, "jhon@gmail.com", status.OFFLINE);

                Console.WriteLine(
                    "\nCHAT DATA" +
                    "\nUser name: " + chat1.username +
                    "\nUser age: " + chat1.usergender +
                    "\nUser gender: " + chat1.userage +
                    "\nemail: " + chat1.email +
                    "\nStatus: " + chat1.chatStatus
                    );
                Console.ReadLine();
            }

        }
    }

    namespace Array
    {
        class Program
        {
            /*1. Write a program, which creates an array of 20 elements of type integer and initializes each of the elements with a 
             value equals to the index of the element multiplied by 5. Print the elements to the console.*/
            public static void PrintArray(int[] arr)
            {
                foreach (int item in arr)
                {
                    Console.WriteLine(item);
                }
            }

            public static int[] ReadArray()
            {
                Console.Write("Please enter length of the array: ");
                int length = int.Parse(Console.ReadLine());
                int[] array = new int[length];
                for (int i = 0; i < length; i++)
                {
                    Console.Write("Please enter number in position " + i + ": ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                return array;
            }

            public static Boolean equalsArrays(int[] array1, int[] array2)
            {
                bool validation = true;
                if (array1.Length == array2.Length)
                {
                    for (int i = 0; i < array1.Length; i++)
                    {
                        if ((array1[i] - array2[i]) != 0)
                        {
                            validation = false;
                            break;
                        }
                    }
                }
                return validation;
            }

            public static void Question1()
            {
                int numArray = 20;
                int[] arr = new int[numArray];

                for (int i = 0; i < numArray; i++)
                {
                    arr[i] = i * 5;
                }
                PrintArray(arr);
            }

        /*2. Write a method, which reads two arrays from the console and checks whether they are equal (two arrays are equal 
            *when they are of equal length and all of their elements, which have the same index, are equal).*/
            public static void Question2()
            {
                int[] array1, array2;
                array1 = ReadArray();
                array2 = ReadArray();
                Console.Write("\nArray one: \n"); PrintArray(array1);
                Console.Write("\nArray two: \n"); PrintArray(array2);
                if ((equalsArrays(array1, array2)) is true)
                {
                    Console.WriteLine("\nThe two arrays are equal");
                }
                else
                {
                    Console.WriteLine("\nThe two arrays are not equal");
                }
                Console.ReadLine();
            }

            /*3. Sorting an array means to arrange its elements in an increasing (or decreasing) order. Write a method, 
             which sorts an array using the algorithm "bubble sort".*/
            public static void Question3()
            {
                int[] array; //= {4,10,3,5,8,12,1};
                array = ReadArray();
                int tmp;
                Console.Write("\nArray without sort: \n"); PrintArray(array);
                for (int j = 0; j <= array.Length - 2; j++)
                {
                    for (int i = 0; i <= array.Length - 2; i++)
                    {
                        if (array[i] > array[i + 1])
                        {
                            tmp = array[i + 1];
                            array[i + 1] = array[i];
                            array[i] = tmp;
                        }
                    }
                }
                Console.Write("\nArray sorted: \n"); PrintArray(array);
                Console.ReadLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Types_variables.Program.Question1();
            //Types_variables.Program.Question2();
            //Types_variables.Program.Question3();

            //FlowControl.Program.Question1();

            //Enumerations.program.Questions();

            //Array.Program.Question1();
            //Array.Program.Question2();
            Array.Program.Question3();

        }
    }

}
