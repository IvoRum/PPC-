using System.ComponentModel;

namespace Zad2;

public class NutsTopping:Topping, Icomponent
{
    public NutsTopping(Icomponent input) : base(input)
    {
    }
    
    public void AddTopping()
    {
        this.input.AddTopping();
        Console.WriteLine("Nuts Topping added");
    }
}