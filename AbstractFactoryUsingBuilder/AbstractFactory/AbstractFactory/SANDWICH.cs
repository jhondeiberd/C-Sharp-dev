using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
   public class SANDWICH

    {

        public String bread;
        public String salade;
        public String topping;


        public void setBread(String b)
        {
            this.bread = b;
        }
        public void setTopping(String t)
        {
            this.topping = t;
        }
        public void setSalade(String s)
        {
            this.salade = s;
        }
        public string getBread()
        {
            return this.bread;
        }
        public string getSalade()
        {
            return this.salade;
        }
        public string getTopping()
        {
            return this.topping;
        }
        public void display()
        {
            Console.WriteLine("this is a sandwich with " + this.getBread() + " " +
                this.getSalade() + " " + this.getTopping());
        }
    }
}
