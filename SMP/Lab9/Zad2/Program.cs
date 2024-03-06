// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using Zad2;

public class Manager
{
    static void Main()
    {
        Icomponent a = new PlainIceCream(); 
        Icomponent b = new CandyTopping(a); 
        Icomponent c = new PeanutTopping(b); 
        Icomponent d = new NutsTopping(c); 
        
        d.AddTopping();
    }
}