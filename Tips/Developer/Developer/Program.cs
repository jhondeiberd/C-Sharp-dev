using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Developer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*objects
             //adress person1;
             //person1.number = 50;
             //person1.street = "Quintin";
             //person1.apt = 205;
             //person1.city = "Montreal";
             //Console.WriteLine(person1.getadress());

            //Person person1 = new Person();
            //person1.Name = "Jhon Diaz";
            //person1.Age = 40;
            //Console.WriteLine("Persona 1 Name: {0} Age: {1}", person1.Name, person1.Age);

            //Person person2 = person1;
            //person2.Name = "Marleny de Diaz";
            //person2.Age = 41;
            //Console.WriteLine("Persona 2 Name: {0} Age: {1}", person2.Name, person2.Age);
            //Console.WriteLine("Persona 1 Name: {0} Age: {1}", person1.Name, person1.Age);
 
            //Console.WriteLine("Hello world");
            //Console.ReadKey();
            //int result = Square(5);
            //Console.WriteLine(result);
            //Console.ReadKey();
            */

            /*Constructor
            Color color1 = new Color();
            color1.R = 254;
            color1.G = 500;
            color1.B = 455;

            Console.WriteLine("Color 1 R: {0} G: {1} B: {2}", color1.R, color1.G, color1.B);
            Console.ReadKey();
            */

            /*CONDITIONALS
                //if
                //if (1 > 0)
                //{
                //    Console.WriteLine("True");
                //    Console.ReadKey();
                //} else
                //{
                //    Console.WriteLine("False");
                //    Console.ReadKey();
                //}

                //Case
                //Console.Write("Type a letter a, b o c\n");
                //char letter = (char)Console.Read();
                //switch (letter)
                //{
                //    case 'a':
                //        Console.WriteLine("Lettre a");
                //        Console.ReadKey();
                //        break;
                //    case 'b':
                //        Console.WriteLine("Lettre b");
                //        Console.ReadKey();
                //        break;
                //    case 'c':
                //        Console.WriteLine("Lettre c");
                //        Console.ReadKey();
                //        break;
                //    default:
                //        Console.WriteLine("Other letter");
                //        Console.ReadKey();
                //        break;
                //}
            }
            */

            /*ITERATIONS
                //Console.Write("Type the number of times:\n");
                //int times = Convert.ToInt32(Console.ReadLine());
                ////Do while
                ////int n = 0;
                ////do
                ////{
                ////    Console.WriteLine("Iterations");
                ////    ++n;
                ////} while (n < times);
                ////Console.WriteLine("Repeats " + times);
                ////Console.ReadKey();

                //int n1 = 0;
                //while (n1 < times)
                //{
                //    Console.WriteLine("Iterations"); 
                //    ++n1;
                //}
                //Console.WriteLine("Repeats " + times);
                //Console.ReadKey();
            */

            /*VARIABLES
                //int a = 10;
                //long i = 1;
                //double e = 10.5;
                //bool p = false;
                //ulong ul = 1ul; 
                //float d = 10.5f;
                //decimal de = 1.0m;
                //char b = 'a';
                //string c = "Hello";
                //const double pi = 3.1416;

                //CONVERTION
                //int a = 10;
                //double b = 10.5;
                //a = (int)b;
                //b = a;
                //double x = 12.89;
                //long y = (long)x;
            */

            /*JUMP SENTENCES
                //break;
                //continue;
                //goto;
            */         
            
        }      

        /*METHODS
        public static int Square(int x)
        {
            return x * x;
        }
        */
        
    }   
    
}

/*STRUCTURE
struct adress
{
    public int number;
    public string street;
    public int apt;
    public string city;

    public string getadress()
    {
        return number + " " + street + " apt. " + apt + ", " + city;
    }
}

public class Person
{
    public string Name;
    public int Age;
}

public class Book
{
    public string Title;
    public string Author;
    public float Price;
    public bool PaperCover;
    public Book(string title, string author, float price, bool paperCover)
    {
        Title = title;
        Author = author;
        Price = price;
        PaperCover = paperCover;
    }
}
*/

/*CONSTRUCTORS
public class Color
{
    private int r;
    private int g;
    private int b;

    public int R
    {
        get { return r; }
        set
        {
            if (value <= 255)
            { r = value; }
            else { r = 255; }
        }
    }

    public int G
    {
        get { return g; }
        set
        {
            if (value <= 255)
            { g = value; }

            { g = 255; }
        }
    }

    public int B
    {
        get { return b; }
        set
        {
            if (value <= 255)
            { b = value; }

            { b = 255; }
        }
    }
}
*/
