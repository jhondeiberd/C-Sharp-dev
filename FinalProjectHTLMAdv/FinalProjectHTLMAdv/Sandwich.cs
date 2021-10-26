using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectHTLMAdv
{
    public class Sandwich
    {
        public string Name { get; set; }
        public string Bread { get; set; }
        public string Sauce { get; set; }
        public string Tomato { get; set; }
        public string Onion { get; set; }
        public string Topping { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return string.Format("Price: {0}\t\t\t\tProduct: {1}\n\t{2}\n\t{3}\n\t{4}\n\t{5}\n\t{6}\n",
                                this.Price, this.Name, this.Bread, this.Sauce, this.Tomato, this.Onion, this.Topping);
        }

    }
}
