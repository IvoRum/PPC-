// See https://aka.ms/new-console-template for more information

using PPC_dom5.Zad_2;

class Program
{
    static void Main(string[] args)
    {
        Box box1 = new Box(5,4);
        Console.WriteLine(box1.length() + " / " + box1.width());
        IDimensions dimens = new Box((float)3.3, (float)4.1);
        Console.WriteLine(dimens.length() + " / " + dimens.width());
        Console.WriteLine("\n");

    }
}