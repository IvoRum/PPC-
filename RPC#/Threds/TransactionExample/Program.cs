using System;
using System.Threading;

namespace ConsoleApp20
{
    class Department
    {
        private Object thisLock = new Object();
        int salary;
        Random r = new Random();
        public Department(int initial)
        {
            salary = initial;
        }
        int Withdraw(int amount)
        {
            // Това състояние никога не е true, освен ако не се
            // коментира реда lock (thisLock)
            if (salary < 0)
            {
                throw new Exception("Negative Balance");
            }
            // Коментирайте този ред, за да видите ефекта от ключовата дума
            // lock.
            lock (thisLock)
            {
                if (salary >= amount)
                {
                    Console.WriteLine("salary before Withdraw :  " + salary);
                    Console.WriteLine("Amount to Withdraw        : -" + amount);
                    salary = salary - amount;
                    Console.WriteLine("salary after Withdraw  :  " + salary);
                    Console.WriteLine("--------------------------------");
                    return amount;
                }
                else
                {
                    return 0; // Танзакцията е отказана
                }
            }
        }
        public void DoTransactions()
        {
            for (int i = 0; i < 100; i++)
            {
                Withdraw(r.Next(1, 100));
            }
        }
    }
    class Process
    {
        static void Main()
        {
            Thread[] threads = new Thread[10];
            Department dep = new Department(1000);
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(new ThreadStart(dep.DoTransactions));
                threads[i] = t;
            }
            for (int i = 0; i < 10; i++)
            {
                threads[i].Start();
            }
            Console.Read();
        }
    }
}