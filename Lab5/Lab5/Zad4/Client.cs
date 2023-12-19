using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC_dom5.Zad4
{
    class Client : IAccount
    {
        private int _Ammount;
        private int _InterestRate;
        private String _Name;

        public Client(String Name, int Ammount, int InterestRate)
        {
            _Name = Name;
            _Ammount = Ammount;
            _InterestRate = InterestRate;
        }

        public String Name
        {
            get
            {
                return _Name;
            }
        }
        public int Ammount
        {
            get
            {
                return _Ammount;
            }
        }

        public int InterestPercent
        {
            get
            {
                return _InterestRate;
            }
        }

        public void deposit(int Sum)
        {
            _Ammount += Sum;
        }

        public void withdraw(int Sum)
        {
            _Ammount -= Sum;
        }
    }
}
