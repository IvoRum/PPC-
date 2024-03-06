using System.ComponentModel;

namespace Zad2;

public class CandyTopping:Topping ,Icomponent
{
    public CandyTopping(Icomponent input) : base(input)
    {
        
    }

    public void AddTopping()
    {
        Console.WriteLine("Candy Topping added");
    }
}