using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Client
    {
        private int tableNo;
        List<MenuItem> deliveredItems = new List<MenuItem>();
        private Waiter waiter;

        public Client(int tableNo, Waiter waiter)
        {
            this.tableNo = tableNo;
            this.waiter = waiter;
        }
        
        public void makeOrder(string order)
        {
            waiter.takeOrder(new Order(waiter,this,order));
        }

        public void recieveItem(MenuItem item)
        {
            deliveredItems.Add(item);
        }

        public void printItems()
        {
            Console.WriteLine("Delivered items for table " + tableNo + ":");
            foreach (MenuItem item in deliveredItems)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
