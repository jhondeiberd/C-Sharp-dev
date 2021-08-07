using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises6
{
    namespace Inheritance
    {
        //2. Define a class Human with properties "FirstName" and "LastName".
        //Define the class Student inheriting Human, which has the property "Mark".
        //Define the class Worker inheriting Human with the property "rate" and "hours worked".
        //Implement a "CalculateSalary" method, which calculates a worker’s salary based on rate and hours worked.
        //Write the corresponding constructors and encapsulate all data in properties.
        class Human
        {
            private string firstName;
            private string lastName;
            public string FirstName {get; set;}
            public string LastName {get; set;}

            public Human(string firstName, string lastName)
            {
                LastName = lastName;
                FirstName = firstName;
            }
        }

        class Student : Human
        {
            public bool Mark { get; set; }

            public Student(bool mark, string lastName, string fisrtName) : base(lastName, fisrtName)
            {
                Mark = mark;
            }
        }

        class Worked : Human
        {
            public float Rate { get; set; }
            public float HoursWorked { get; set; }

            public Worked(float rate, float hoursWorked, string lastName, string fisrtName) : base(lastName, fisrtName)
            {
                Rate = rate;
                HoursWorked = hoursWorked;
            }

            public float CalculateSalary()
            {
                return Rate * HoursWorked;
            }
        }   
    }

    namespace Polymorphism
    {
        abstract class Animal
        {
            private int age;
            private string name;
            private string gender;

            public int Age { get; set;}
            public string Name { get; set;}
            public string Gender { get; set;}
            public virtual void SoundAnimal()
            {
                Console.WriteLine("The animal makes a sound: ");
            }

        }
        class Dog : Animal
        {
            public override void SoundAnimal()
            {
                base.SoundAnimal();
                Console.WriteLine("Dog: gua gua");
            }
        }
        class Cat : Animal
        {
            public override void SoundAnimal()
            {
                base.SoundAnimal();
                Console.WriteLine("Cat: miau miau");
            }
        }
        class Frog : Animal
        {
            public override void SoundAnimal()
            {
                base.SoundAnimal();
                Console.WriteLine("Frog: crua crua");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Polymorphism.Animal[] animals = new Polymorphism.Animal[6];
            Random rnd = new Random();
            for (int i = 0; i < animals.Length; i++)
            {
                int kind = rnd.Next() % 3;
                switch (kind)
                {
                    case 0:
                        animals[i] = new Polymorphism.Dog();
                        break;
                    case 1:
                        animals[i] = new Polymorphism.Cat();
                        break;
                    case 2:
                        animals[i] = new Polymorphism.Frog();
                        break;
                }
                animals[i].SoundAnimal();
            }
            Console.ReadLine();
        }
    }

}
