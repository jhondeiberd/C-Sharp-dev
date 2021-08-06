using System;

namespace _06___cast_up_and_down
{
    abstract class Instrument
    {
        public int Weight { get; set; }

        public virtual void Play()
        {
        }
    }

    class Saxophon : Instrument
    {
        public int Type { get; set; }

        public override void Play()
        {
            Console.WriteLine("Saxo is playing");
        }
    }
    class Guitar : Instrument
    {
        public int NumOfStrings { get; set; }
        public override void Play()
        {
            Console.WriteLine("Guitar is playing");
        }
    }
    class Piano : Instrument
    {
        public int NumOfKeys { get; set; }

        public override void Play()
        {
            Console.WriteLine("Piano is playing");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // creation of the orchestra
            Instrument[] orchestra = new Instrument[5];
            Random rnd = new Random();
            for (int i = 0; i < orchestra.Length; i++)
            {
                int kind = rnd.Next() % 3;
                switch (kind)
                {
                    case 0:
                        orchestra[i] = new Saxophon();
                        break;
                    case 1:
                        orchestra[i] = new Guitar();
                        break;
                    case 2:
                        orchestra[i] = new Piano();
                        break;
                }
            }

            // Print informations about each instruments
            foreach (var instr in orchestra)
            {

                if (instr is Piano)
                {
                    Console.WriteLine("Piano : {0} keys.", ((Piano)instr).NumOfKeys);
                }
                else if (instr is Saxophon)
                {
                    Console.WriteLine("Saxo : type is {0} ", ((Saxophon)instr).Type);
                }
                else
                {
                    Console.WriteLine("Guitar : {0} strings.", ((Guitar)instr).NumOfStrings);
                }
            }

            // Make the orchestra play
            Console.WriteLine("----------- foreach loop ------------");
            foreach (var instr in orchestra)
            {
                instr.Play();
            }

            Console.WriteLine("----------- for loop ------------");
            for (int i = 0; i < orchestra.Length; i++)
            {
                orchestra[i].Play();
            }

            //orchestra[1] = new Instrument();
        }
    }
}
