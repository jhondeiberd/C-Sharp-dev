using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

        }
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
            Console.WriteLine("     {0}", b.Title);
        }

        static void AddBook(BookDB bookDB)
        {
            bookDB.AddBook("The programming Language", "Brian W.", 19.95f, true);
            bookDB.AddBook("The unicode 2.0", "Consortium", 39.95f, true);
            bookDB.AddBook("The MS-DOS Encyclopedia", "Ray Duncan", 129.95f, false);
        }

    }
    public delegate void Del(string message);
    public delegate void CustomDel(string message);
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

