using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }


        public override string ToString()
        {
            return string.Format("Account number: {0}, Password: {1}, Balance: {2}", 
                this.AccountNumber, this.Password, this.Balance);
        }
    }
}
