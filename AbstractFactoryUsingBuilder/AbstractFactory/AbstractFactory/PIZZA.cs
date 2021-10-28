using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class PIZZA
    {

        public String dough;
        public String sauce;
        public String topping;


        public void setDough(String d)
        {
            this.dough = d;
        }
        public void setTopping(String t)
        {
            this.topping = t;
        }
        public void setSauce(String s)
        {
            this.sauce = s;
        }


        public string getDough()
        {
            return this.dough ;
        }
        public string getTopping()
        {
            return this.topping;
        }
        public string getSauce()
        {
           return this.sauce ;
        }
        public void display()
        {
            Console.WriteLine("this is a pizza with " + this.getDough() + " " +
                this.getSauce() + " " + this.getTopping());
        }
    }
}
