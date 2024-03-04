using System;
using System.Collections.Generic;
using System.Text;

namespace KontrolnoPPC1
{
    class Bank
    {
        private BankAccount[] _BankAccounts;
        
        public Bank()
        {
            List <BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount("User", "Password", "1234045123", BankAccountType.Current, "Name1 Name2 Name3", (float)2001.3));
            accounts.Add(new BankAccount("User2", "Password2", "41240515623", BankAccountType.ForeignCurrency, "Name1 Name4 Name6", (float)931.23));
            accounts.Add(new BankAccount("User54", "Password245", "124519564123", BankAccountType.ForeignCurrency, "Name2 Name5 Name3", (float)234.87));
            accounts.Add(new BankAccount("User9", "Password34", "155321512433", BankAccountType.ForeignCurrency, "Name12 Name5 Name34", (float)10043.32));
            _BankAccounts = accounts.ToArray();
        }

        public void PrintAccountsInfo()
        {
            foreach(BankAccount bankAccount in _BankAccounts)
            {
                bankAccount.Info();
            }
        }
    }
}
