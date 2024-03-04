using System;

class Program
{
    enum gradus : int
    {
        min = 0,
        krit = 72,
        max = 100,
    }

    static void Main()
    {
        Console.WriteLine("temperature " + gradus.min + "=" + (int)gradus.min);
        Console.WriteLine("temperature " + gradus.krit + "=" + (int)gradus.krit);
        Console.WriteLine("temperature " + gradus.max + "=" + (int)gradus.max);
        Console.ReadLine();
    }
}
