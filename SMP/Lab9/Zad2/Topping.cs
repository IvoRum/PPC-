using System.ComponentModel;

namespace Zad2;

public class Topping:Icomponent
{
    internal Icomponent input;

    public Topping(Icomponent input)
    {
        this.input = input;
    }

    public void AddTopping()
    {
        input.AddTopping();
    }
}