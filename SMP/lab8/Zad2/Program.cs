// See https://aka.ms/new-console-template for more information

using Zad2;

public class Manager
{
    static void Main()
    {
        Worker a = new Worker("Worker Tom", 5);
        Supervisor b = new Supervisor("Supervisor Mary", 6);
        Supervisor c = new Supervisor("Supervisor Jerry", 7);
        Supervisor d = new Supervisor("Supervisor Bob", 9);
        Worker e = new Worker("Worker Jimmy", 8);

        b.AddSubordinate(a); //Tom works for Mary 
        c.AddSubordinate(b); //Mary works for Jerry 
        c.AddSubordinate(d); //Bob works for Jerry 
        d.AddSubordinate(e); //Jimmy works for Bob 

        if (c is IEmployee)
        {
            (c as IEmployee).ShowHappiness();
        }
    }
}