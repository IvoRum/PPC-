using System;
#if STRONG
[assembly: System.Reflection.AssemblyVersion("1.0.0.0")]
#endif
public class New_Server
{
    public static void Display()
    {
        Console.WriteLine("This is new server!!!");
        string s=Console.ReadLine();
    }
}