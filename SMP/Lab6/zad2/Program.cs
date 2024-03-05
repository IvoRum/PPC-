// See https://aka.ms/new-console-template for more information

using zad2;

public class Manager
{
    static void Main()
    {
        ITarget Itarget = new EmployeeAdapter();
        ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
        client.ShowEmployeeList();
        Console.ReadKey();
    }
}