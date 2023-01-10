using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LIST AND ARRAYLIST
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

            Console.WriteLine("******  DICTIONARY  *******");
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


        }
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
}
