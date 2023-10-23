using System;
#if STRONG
[assembly: System.Reflection.AssemblyVersion("2.0.1.0")]
#endif
 
public class New_Server
{
    public static void Display()
    {
        Console.WriteLine("This is new server!!!");
        string s=Console.ReadLine();
    }
}