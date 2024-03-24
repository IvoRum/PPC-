using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file path: ");
            String FilePath = Console.ReadLine();
            Console.WriteLine(new ConcreteReaderCreator(FilePath).CreateReader().readFile());
        }
    }
}
