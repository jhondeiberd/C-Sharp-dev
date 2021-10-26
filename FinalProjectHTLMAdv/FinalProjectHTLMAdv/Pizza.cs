using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Cheese { get; set; }
        public string Sauce { get; set; }
        public string Topping { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return string.Format("Price: {0}\t\t\t\tProduct: {1}\n\t{2}\n \t{3}\n \t{4}\n",
                                this.Price, this.Name, this.Cheese, this.Sauce, this.Topping);
        }
    }
}
