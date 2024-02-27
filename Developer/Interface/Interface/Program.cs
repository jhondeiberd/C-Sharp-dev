using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tank tank1 = new Tank();
            tank1.Turn(45, "right");
            tank1.Shoot();
            tank1.Stop();
            tank1.Reload();
            tank1.Accelerate(10);
            Console.ReadKey();

        }
    }
    interface ICar
    {
        void Accelerate(int kmh);
        void Stop();
        void Turn(int angle, string direction);
    }
    interface IWarWeapon
    {
        void Shoot();
        void Reload();
    }

    class Tank : IWarWeapon, ICar
    {
        public void Accelerate(int kmh)
        {
            Console.WriteLine("Tank is accelerating to {0} km/h", kmh);
        }

        public void Reload()
        {
            Console.WriteLine("Tank is reloading");
        }

        public void Shoot()
        {
            Console.WriteLine("Tank is shooting");
        }

        public void Stop()
        {
            Console.WriteLine("Tank is stopping");
        }

        public void Turn(int angle, string direction)
        {
            Console.WriteLine("Tank is turning {0} grades to the {1}", angle, direction);
        }
    }


}
