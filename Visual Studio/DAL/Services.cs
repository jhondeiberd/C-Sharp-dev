using Model;
using System.Collections.Generic;
using System.IO;

namespace DAL
{
    public static class AccountService
    {
        public static string filePath = "../../Account.txt";

        public static void AddAccountToDataStorage(Account accountAdd)
        {
            string str = string.Format("{0},{1},{2}\n", accountAdd.AccountNumber, accountAdd.Password, accountAdd.Balance);
            File.AppendAllText(filePath, str);
        }

        public static void DepositMoney(int AccountNumber, decimal amount)
        {


        }

        public static void WithdrawMoney(int AccountNumber, decimal amount)
        {

        }


        public static Account GetAccountByNumberPass(int AccountNumber, string Password)
        {
            Account foundAccount = null;

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (int.Parse(data[0]) == AccountNumber && data[1] == Password)
                {
                    foundAccount = new Account
                    {
                        AccountNumber = int.Parse(data[0]),
                        Password = data[1],
                        Balance = decimal.Parse(data[2])
                    };
                    break;
                }
            }
            return foundAccount;
        }

        public static List<Account> GetAllAccountsFromDataStorage()
        {
            List<Account> accounts = new List<Account>();

            try
            {

                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    accounts.Add(new Account
                    {
                        AccountNumber = int.Parse(data[0]),
                        Password = data[1].ToString(),
                        Balance = decimal.Parse(data[2])
                    });
                }
            }
            catch (FileNotFoundException)
            {

            }
            return accounts;
        }

        public static bool DeleteAccountToDataStorage(int AccountNumber)
        {
            bool validate = false;
            string[] lines = File.ReadAllLines(filePath);
            string[] newLines = new string[lines.Length - 1];
            int j = 0;
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (int.Parse(data[0]) == AccountNumber)
                {
                    validate = true;
                }
                else
                {
                    newLines[j] = string.Format("{0},{1},{2}", data[0], data[1], data[2]);
                }

                j++;
            }
            File.WriteAllLines(filePath, newLines);
            return validate;
        }

        public static bool SetAccountByAccount(Account ac)
        {
            bool validate = false;
            string[] lines = File.ReadAllLines(filePath);
            string[] newLines = new string[lines.Length];
            int j = 0;
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (int.Parse(data[0]) == ac.AccountNumber)
                {
                    newLines[j] = string.Format("{0},{1},{2}", data[0], ac.AccountNumber, ac.Password, ac.Balance);
                    validate = true;
                }
                else
                {
                    newLines[j] = string.Format("{0},{1},{2}", data[0], data[1], data[2]);
                }
                j++;
            }
            File.WriteAllLines(filePath, newLines);
            return validate;
        }



    }
}
