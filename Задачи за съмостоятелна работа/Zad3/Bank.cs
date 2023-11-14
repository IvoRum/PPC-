using System;

public class Bank{
    static void Main()
    {
        Account userAccount = new Account(13, 24);
        int option = 0;
        do {
            Console.WriteLine("Chose and option 1-put money in account, 2- take money, 3- view balance, 4-exit");
            option= Int32.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: Console.WriteLine("Haw much money?");
                    if (userAccount.putMoney(Int32.Parse(Console.ReadLine())) == 1)
                    {
                        Console.WriteLine("Transaction was succsessfull!");
                    }
                    else {
                        Console.WriteLine("Transaction was FAILD!");
                    }
                    break;
                case 2: Console.WriteLine("Haw much money?");
                    int putmoneyResult = userAccount.getMoeny(Int32.Parse(Console.ReadLine()));
                    if (putmoneyResult == 1)
                    {
                        Console.WriteLine("Transaction was succsessfull!");
                    }
                    else if (putmoneyResult == 3) {
                        Console.WriteLine("Credid has been added");
                    }
                    else
                    {
                        Console.WriteLine("Transaction was FAILD!");
                    }
                    break;
                case 3: Console.WriteLine(userAccount.getBalance()); break;
            }
        } while(option!=4);
        Console.WriteLine("Goodbay!");
    }

    /**
* Transational status
* 0 - sum provided is 0 or >0
* 1 - transactiona succsessfull
* 2 - trasaction exids ballanse
* 3 - creddid hase beed added to balace
*/
    private class Account
    {
        int balanse;
        int credit;
        int debit;

        public Account( int credit, int debit)
        {
            this.credit = credit;
            this.debit = debit;
            this.balanse = debit - credit;
        }

        public int putMoney(int sum)
        {
            if (sum > 0)
            {
                if (this.credit > 0)
                {
                    this.credit = this.credit - sum;
                    recalcutateBalace();
                    return 1;
                }
                this.debit = debit + sum;
                recalcutateBalace();
                return 1;
            }
            return 0;
        }

        public int getMoeny(int sum)
        {
            if (sum > 0)
            {
                if (sum > balanse)
                {
                    this.credit = this.credit + sum;
                    recalcutateBalace();
                    return 3;
                }
                else
                {
                    this.debit = this.debit - sum;
                    recalcutateBalace();
                    return 1;
                }

            }
            return 0;
        }

        public int getBalance() {
            return this.balanse;
        }

        private void recalcutateBalace()
        {
            this.balanse = this.debit - this.credit;
        }
    }
}