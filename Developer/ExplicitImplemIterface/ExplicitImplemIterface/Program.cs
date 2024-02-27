using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitImplemIterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(15.2f, 33.5f);
            IMetricMeasure square1Metric = square1;
            IEnglishMeasure square1English = square1;

            Console.WriteLine("Square 1 Large: {0} cm", square1Metric.Large());
            Console.WriteLine("Square 1 Width: {0} cm", square1Metric.Width());
            Console.WriteLine("Square 1 Large: {0}'' ", square1English.Large());
            Console.WriteLine("Square 1 Width: {0}'' ", square1English.Width());
            Console.ReadKey();

        }
    }

    interface IMetricMeasure
    {
        float Large();
        float Width();
    }
    interface IEnglishMeasure
    {
        float Large();
        float Width();
    }
    public class Square : IMetricMeasure, IEnglishMeasure
    {
        public float LargeInches;
        public float WidthInches;
        public Square(float LargeInches, float WidthInches)
        {
            this.LargeInches = LargeInches;
            this.WidthInches = WidthInches;
        }

        float IEnglishMeasure.Large() { return LargeInches; }
        float IEnglishMeasure.Width() { return WidthInches; }
        float IMetricMeasure.Large() { return LargeInches * 2.54f; }
        float IMetricMeasure.Width() { return WidthInches * 2.54f; }
    }

}
