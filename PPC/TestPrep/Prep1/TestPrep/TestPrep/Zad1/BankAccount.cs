using System;
using System.Collections.Generic;
using System.Text;

namespace KontrolnoPPC1
{
    struct BankAccount
    {
        private String _User;
        private String _Password;
        private String _AccountNumber;
        private BankAccountType _BankAccountType;
        private String _HolderName;
        private float _Availability;

        public BankAccount(string user, string password, string accountNumber, BankAccountType bankAccountType, string holderName, float availability)
        {
            _User = user;
            _Password = password;
            _AccountNumber = accountNumber;
            _BankAccountType = bankAccountType;
            _HolderName = holderName;
            _Availability = availability;
        }

        public string User { get => _User; set => _User = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string AccountNumber { get => _AccountNumber; set => _AccountNumber = value; }
        public string HolderName { get => _HolderName; set => _HolderName = value; }
        public float Availability { get => _Availability; set => _Availability = value; }
        internal BankAccountType BankAccountType { get => _BankAccountType; set => _BankAccountType = value; }

        private String getAccountTypeAsString()
        {
            switch (_BankAccountType)
            {
                case BankAccountType.Current:
                    return "Current";
                case BankAccountType.ForeignCurrency:
                    return "ForeignCurrency";
            }
            return null;
        }

        public void Info()
        {
            Console.WriteLine(this.ToString());
        }

        public override String ToString()
        {
            return "User Name: " + _User + " Holder Name: " + _HolderName + " Account Number: " + _AccountNumber +
                " Account Type: " + getAccountTypeAsString() + " Availability: " + _Availability.ToString() + "\n";
        }
    }

}
