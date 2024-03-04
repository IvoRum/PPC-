using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC_dom5.Zad4
{
    interface IAccount
    {
        int Ammount
        {
            get;
        }
        int InterestPercent
        {
            get;
        }
        public void deposit(int Sum);
        public void withdraw(int Sum);
    }
}
