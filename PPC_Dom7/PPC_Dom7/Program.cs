using System;
using System.Collections;
using System.Collections.Generic;
using PPC_Dom7.Zad1;
using PPC_Dom7.Zad2;

namespace PPC_Dom7
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad 1
            ArrayList input = new ArrayList();
            input.Add("Sergei Nikolaev Ivanov 20 64");
            input.Add("Igor Yuriev Petrov 45 88");
            input.Add("Michail Aleksiev Nikolaev 20 70");
            input.Add("Aleksander Dimitrov Plamenov 53 101");
            input.Sort(new Zad1.StringComparer());
            foreach(Object obj in input)
            {
                Console.WriteLine((String)obj);
            }
            //zad 2
            EmployeeLIst list = new EmployeeLIst();
            list.AddEmployee(new Employee("Mike",1, DateTime.Now.AddDays(2)));
            list.AddEmployee(new Employee("Dave", 4, DateTime.Now.AddDays(1)));
            list.AddEmployee(new Employee("Biff", 3, DateTime.Now.AddDays(4)));
            list.AddEmployee(new Employee("Leela", 2, DateTime.Now.AddDays(9)));
            list.PrintSortedList();
            Console.WriteLine(list.FindEmployee("Biff").ToString());
            Console.WriteLine(list.HighestLevelEmployee());
            list.RemoveEmployee(list.FindEmployee("Dave"));
            list.PrintSortedList();

        }
    }
    
}
