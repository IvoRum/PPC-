// See https://aka.ms/new-console-template for more information

using Lab13ChainOfResponsibility;

public class Manager
{
    static void Main()
    {
        Handler h1 = new ConcreteHandler1(); 
        Handler h2 = new ConcreteHandler2(); 
        Handler h3 = new ConcreteHandler3(); 
        h1.SetSuccessor(h2); 
        h2.SetSuccessor(h3); 
        int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 }; 
        
        foreach (int request in requests) 
        { 
            h1.HandleRequest(request); 
        } 
        Console.ReadKey(); 
    }
}