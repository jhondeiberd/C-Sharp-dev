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

            /*EXPLICIT IMPLEMENTATION INTERFACE
            //    Square square1 = new Square(15.2f, 33.5f);
            //    IMetricMeasure square1Metric = square1;
            //    IEnglishMeasure square1English = square1;

            //    Console.WriteLine("Square 1 Large: {0} cm", square1Metric.Large());
            //    Console.WriteLine("Square 1 Width: {0} cm", square1Metric.Width());
            //    Console.WriteLine("Square 1 Large: {0}'' ", square1English.Large());
            //    Console.WriteLine("Square 1 Width: {0}'' ", square1English.Width());
            //    Console.ReadKey();
            */

            /*COLLECTIONS
            /*LIST AND ARRAYLIST
            //var name = new List<string> { "First", "Second", "Third" };
            //var name = new List<string>();
            ArrayList name = new ArrayList();
            name.Add(10.11);
            name.Add(2);
            name.Add("Third");
            Console.WriteLine(name[2]);
            name.Add("Fourth");
            name.Add("Fifth");
            name.Remove(name[2]);
            Console.WriteLine(name[2]);

            foreach (var state in name)
            {
                Console.Write(state + " \n");
            }
            Console.ReadKey();
            */

            /*DICTIONARY
            Dictionary<string, Element> elements = new Dictionary<string, Element>
            {
                {"K", new Element("K", "Potasio", 19) },
                {"Na", new Element("Na", "Sodio", 11) },
                {"Cl", new Element("Cl", "Cloro", 17) }
            };
            
            foreach (KeyValuePair<string, Element> kvp in elements)
            {
                Element element1 = kvp.Value;
                Console.WriteLine("Key: {0} Name: {1} Number: {2}", kvp.Key, element1.Name, element1.AtomicNumber);
            }
            Console.ReadKey();
            */

            /*DELEGATE
            Del Delegator = Example;
            Delegator("Hello world1");
            Example2(1, 2, Delegator);

            CustomDel hiDel, byeDel, multiDel, multiMinusHiDel;
            hiDel = Hello;
            byeDel = Bye;
            multiDel = hiDel + byeDel;
            multiMinusHiDel = multiDel - hiDel;
            Console.WriteLine("Delegate hiDel:");
            hiDel("Jhon");
            Console.WriteLine("Delegate byeDel:");
            byeDel("Jhon");
            Console.WriteLine("Delegate multiDel:");
            multiDel("Jhon");
            Console.WriteLine("Delegate multiMinusHiDel:");
            multiMinusHiDel("Jhon");
            Console.ReadKey();

            BookDB bookList = new BookDB();
            AddBook(bookList);
            Console.WriteLine("Titles with cover paper");

            bookList.ProcessCover(PrintBook);

            Total totalBook = new Total();
            bookList.ProcessCover(totalBook.PriceTotal);

            Console.WriteLine("The total price of all books is: {0}", totalBook.total);
            Console.ReadKey();
            */
            
        }
        /*DELEGATE
        public static void Example(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
        public static void Example2(int param1, int param2, Del call)
        {
            call("The number es: " + (param1, param2).ToString());
        }
        static void Hello(string Mens) { Console.WriteLine("Hello, {0}!", Mens); }
        static void Bye(string Mens) { Console.WriteLine("Goodbye, {0}!", Mens); }
        static void PrintBook(Book b)
        {
            Console.WriteLine("     {0}",b.Title );
        }

        static void AddBook(BookDB bookDB)
        {
            bookDB.AddBook("The programming Language", "Brian W.", 19.95f, true);
            bookDB.AddBook("The unicode 2.0", "Consortium", 39.95f, true);
            bookDB.AddBook("The MS-DOS Encyclopedia", "Ray Duncan", 129.95f, false);
        }
        */

        /*METHODS
        public static int Square(int x)
        {
            return x * x;
        }
        */
        
    }

    /*DELEGATE
    public delegate void Del(string message);
    public delegate void CustomDel(string message);
    */
    
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

public class Element
{
    public string Symbol;
    public string Name;
    public int AtomicNumber;
    public Element(string symbol, string name, int atomicNumber)
    {
        Symbol = symbol;
        Name = name;
        AtomicNumber = atomicNumber;
    }
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

/*DELEGATE
public delegate void ProcessBook(Book book);

public class BookDB
{
    ArrayList list = new ArrayList();
    public void AddBook(string title, string author, float price, bool paperCover)
    {
        list.Add(new Book(title, author, price, paperCover));
    }
    public void ProcessCover(ProcessBook processBook)
    {
        foreach (Book b in list)
        {
            if (b.PaperCover)
                processBook(b);
        }
    }
}
public class Total
{
    public float total;
    public void PriceTotal(Book book)
    {
        total += book.Price;
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

/*EXPLICIT IMPLEMENTATION OF INTERFACES
//interface IMetricMeasure
//{
//    float Large();
//    float Width();
//}
//interface IEnglishMeasure
//{
//    float Large();
//    float Width();
//}
//public class Square : IMetricMeasure, IEnglishMeasure
//{
//    public float LargeInches;
//    public float WidthInches;
//    public Square(float LargeInches, float WidthInches)
//    {
//        this.LargeInches = LargeInches;
//        this.WidthInches = WidthInches;
//    }

//    float IEnglishMeasure.Large() { return LargeInches; }
//    float IEnglishMeasure.Width() { return WidthInches; }
//    float IMetricMeasure.Large() { return LargeInches * 2.54f; }
//    float IMetricMeasure.Width() { return WidthInches * 2.54f; }
//}
*/

