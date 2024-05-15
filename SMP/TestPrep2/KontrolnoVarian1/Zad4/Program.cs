using System;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitchen kitchen = new Kitchen();
            Waiter waiter = new Waiter(kitchen);
            Client client = new Client(1, waiter);
            client.printItems();
            Console.WriteLine("Please enter order: ");
            client.makeOrder(Console.ReadLine());
            kitchen.processOrder();
            waiter.Deliverorder();
            client.printItems();
            Console.WriteLine("Order again? Y/N");
            while (Console.ReadLine().Equals("Y"))
            {
                Console.WriteLine("Please enter order: ");
                client.makeOrder(Console.ReadLine());
                kitchen.processOrder();
                waiter.Deliverorder();
                client.printItems();
                Console.WriteLine("Order again? Y/N");
            }
        }
    }
}
