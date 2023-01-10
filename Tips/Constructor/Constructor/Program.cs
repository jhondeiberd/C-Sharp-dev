using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Color color1 = new Color();
            color1.R = 254;
            color1.G = 500;
            color1.B = 455;

            Console.WriteLine("Color 1 R: {0} G: {1} B: {2}", color1.R, color1.G, color1.B);
            Console.ReadKey();
        }
    }
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

}
