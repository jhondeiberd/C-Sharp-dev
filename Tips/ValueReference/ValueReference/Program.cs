using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            Console.WriteLine("Original list {0}", numbers.Hook());
            int test = 16;
            ref int x = ref numbers.FoundNumbers(test);
            x *= 2;
            Console.WriteLine("New list {0}", numbers.Hook());
            Console.ReadKey();
        }
    }

    class Numbers
    {
        int[] numbers = { 1, 3, 7, 15, 31, 63, 127, 255, 311, 1023 };
        public ref int FoundNumbers(int objective)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= objective)
                {
                    return ref numbers[i];
                }
            }
            return ref numbers[0];
        }
        public string Hook()
        {
            return string.Join (" ", numbers);
        }
    }
}
