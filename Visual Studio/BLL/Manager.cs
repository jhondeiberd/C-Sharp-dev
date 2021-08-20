using DAL;
using Model;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class AccountManager
    {
        public static void AddAccount(Account newAccount)
        {
            AccountService.AddAccountToDataStorage(newAccount);
        }

        public static void DepositMoney(int AccountNumber, decimal amount)
        {
            AccountService.DepositMoney(AccountNumber, amount);
        }

        public static void WithdrawMoney(int AccountNumber, decimal amount)
        {
            AccountService.WithdrawMoney(AccountNumber, amount);
        }

        public static List<Account> GetAllAccounts()
        {
            return AccountService.GetAllAccountsFromDataStorage();
        }

        public static Account GetAccountByNumberPass(int AccountNumber, string Password)
        {
            return AccountService.GetAccountByNumberPass(AccountNumber, Password);
        }

        public static bool SetAccountByAccount(Account ac)
        {
            return AccountService.SetAccountByAccount(ac);
        }
        public static bool DeleteContactToDataStorage(int AccountNumber)
        {
            return AccountService.DeleteAccountToDataStorage(AccountNumber);
        }

    }
}
