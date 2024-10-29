using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLibDump.Model
{
    public class Form
    {
        public Form() { }
        public Form(string valueFr, string valueEn)
        {
            this.ValueFR = valueFr;
            this.ValueEN = valueEn;
        }
        public string ValueFR { get; set; }
        public string ValueEN { get; set; }
    }
}
