// See https://aka.ms/new-console-template for more information

using Zad2;

public class Manager
{
    static void Main()
    {
        ShapeObjectFactory sof = new ShapeObjectFactory();
        sof.GetShape("Rectangle").Print();
        sof.GetShape("Rectangle").Print();
        sof.GetShape("Rectangle").Print();
        
        sof.GetShape("Circle").Print();
        sof.GetShape("Circle").Print();
        sof.GetShape("Circle").Print();
        
        Console.WriteLine(sof.TotalObjectsCreated1);
    }
}