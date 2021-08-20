using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Excercise8
{
    namespace Excercise1
    {
        class Person
        {
            public string FullName { set; get; }
            public int Age { set; get; }
            public Person(string name, int age)
            {
                FullName = name;
                Age = age;
            }
        }
        class Student : Person
        {
            public readonly string StuNumber;
            public Student(string stuNumber, string name, int age)
                : base(name, age)
            {
                StuNumber = stuNumber;
            }
        }
        class Employee : Person
        {
            public float Salary { set; get; }
            public Employee(string name, int age, float salary)
                : base(name, age)
            {
                Salary = salary;
            }
        }
    }
    namespace ListT
    {
        public class Prime
        {
            static List<int> GetPrimes(int num1, int num2)
            {
                List<int> prime = new List<int>();
                bool isPrime = true;

                for (int i = num1; i <= num2; i++)
                {
                    for (int j = 2; j <= num2; j++)
                    {
                        if (i != j && i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        prime.Add(i);
                    }
                    isPrime = true;
                }
                return prime;
            }
            public static void Print(int num1, int num2)
            {
                foreach (int prime in GetPrimes(num1, num2))
                {
                    Console.Write(prime + " ");
                }
            }
        }
    }
    namespace Dictionary
    {
        //Dictionary<int, Person > persons = new Dictionary<int, Person>();

    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrLst = new ArrayList();
            arrLst.Add(new Excercise1.Student("01", "Student 1", 25));
            arrLst.Add(new Excercise1.Employee("Employeed 1", 22, 1000));
            arrLst.Add(new Excercise1.Employee("Employeed 2", 28, 1500));
            arrLst.Add(new Excercise1.Student("02", "Student 2", 21));

            foreach (var item in arrLst)
            {
                if (item is Excercise1.Student)
                {
                    Console.WriteLine("ID_Student: {0}, Name Student: {1}, age Student: {2}",
                        ((Excercise1.Student)item).StuNumber, ((Excercise1.Student)item).FullName, ((Excercise1.Student)item).Age);
                }
                else if (item is Excercise1.Employee)
                {
                    Console.WriteLine("Name employeed: {0}, age employeed: {1}, salary employeed: {2}",
                        ((Excercise1.Employee)item).FullName, ((Excercise1.Employee)item).Age, ((Excercise1.Employee)item).Salary);
                }
            }

            Console.WriteLine("------Excercises List<T>------");
            Console.WriteLine("Please enter the first number to revise numbers prime");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number to revise numbers prime");
            int second = int.Parse(Console.ReadLine());
            ListT.Prime.Print(first, second);
            Console.ReadLine();

        }
    }
}