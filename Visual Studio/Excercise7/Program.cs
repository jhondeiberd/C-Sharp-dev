﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise7
{
    namespace Delegate
    {
        public delegate void DGSaySomething(string str);

        class Person
        {
            public virtual void SaySomething(string str1)
            {
                Console.WriteLine("Person {0}", str1);
            }
        }
        class Chinese : Person
        {
            public override void SaySomething(string str1)
            {
                Console.WriteLine("Chinise {0}", str1);
            }
        }
    }

    namespace DoorOpenEvent
    {
        public delegate void EventHandler(string str);
        class Door
        {
            private bool isOpen = true;
            public int ID { set; get; }
            public bool IsOpen { set; get; }
            public EventHandler<DoorOpenEventArgs> DoorOpenEvent;
        }

        class DoorOpenEventArgs
        {
            public static DateTime Now { get; }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Delegate.Person p1 = new Delegate.Person();
            p1.SaySomething("People");
            p1 = new Delegate.Chinese();
            p1.SaySomething("People");
            Console.ReadLine();
        }
    }
}
