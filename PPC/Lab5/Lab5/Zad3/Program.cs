using System;
using PPC_dom5.Zad3;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect1 = new Rectangle(55, 70);
        IEnglishDimensions eng1 = rect1;
        IMetricDimensions met1 = rect1;
        Console.WriteLine("Lenght (in): {0}", eng1.length());
        Console.WriteLine("Width (in): {0}", eng1.width());
        Console.WriteLine("Lenght (cm): {0}", met1.length());
        Console.WriteLine("Width (cm): {0}", met1.width());
    }
}