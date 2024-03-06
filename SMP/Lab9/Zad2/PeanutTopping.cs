using System.ComponentModel;

namespace Zad2;

public class PeanutTopping:Topping, Icomponent
{
    public PeanutTopping(Icomponent input) : base(input)
    {
    }
    public void AddTopping()
    {
        this.input.AddTopping();
        Console.WriteLine("Peanut Topping added");
    }
}