using System;
using PPC_dom5.Zad4;

class Program
{
    static void Main(string[] args)
    {
        Client cl1 = new Client("Mike",3334, 9);
        Console.WriteLine("Client " + cl1.Name + "\n");
        Console.WriteLine("Initial " + cl1.Ammount + "\n");
        Console.WriteLine("Interest " + cl1.InterestPercent + "\n");
        cl1.deposit(5312);
        Console.WriteLine("Deposit 5312 \n");
        cl1.withdraw(4783);
        Console.WriteLine("Withdraw 4783 \n");
        Console.WriteLine(cl1.Name + " Now has " + cl1.Ammount + "\n");
    }
}