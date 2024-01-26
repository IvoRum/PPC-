// See https://aka.ms/new-console-template for more information

using PPC_Dom6.Zad3.Geometry;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(6);
        Rectangle rectangle = new Rectangle(4, 7);
        Console.WriteLine(square.Describe()+"\n");
        Console.WriteLine(rectangle.Describe() + "\n");
    }
}