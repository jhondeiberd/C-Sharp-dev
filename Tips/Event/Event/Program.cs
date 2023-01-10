using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(54);
            Circle c2 = new Circle(88);

            c1.CircleChanged += HandlerChangedCircle;
            c2.CircleChanged += HandlerChangedCircle;

            c1.Draw();
            c2.Draw();

            c1.Update(57);
            c2.Update(98);
            Console.ReadKey();
        }
        private static void HandlerChangedCircle(object sender, CircleEventArgs AreaChanged)
        {
            Circle s = (Circle)sender;
            Console.WriteLine("New Event. The area of circle now is : {0}", AreaChanged.NewArea);
            s.Draw();
        }
    }
    public class Circle
    {
        private double radius;
        public double Area { get; set; }
        public Circle(double rad)
        {
            radius = rad;
            Area = 3.1416 * radius * radius;
        }
        public void Update(double rad)
        {
            radius = rad;
            Area = 3.1416 * radius * radius;
            OnChangedCircle(new CircleEventArgs(Area));
        }
        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
        public event EventHandler<CircleEventArgs> CircleChanged;
        protected void OnChangedCircle(CircleEventArgs AreaChanged)
        {
            EventHandler<CircleEventArgs> Handler = CircleChanged;
            if (Handler != null)
            {
                Handler(this, AreaChanged);
            }
        }
    }
    public class CircleEventArgs : EventArgs
    {
        public double NewArea { get; set; }
        public CircleEventArgs(double rad)
        {
            NewArea = rad;
        }
    }
}
