using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Kitchen
    {
        Queue<Order> orders = new Queue<Order>();
        public void addOrder(Order order)
        {
            orders.Enqueue(order);
        }

        public void processOrder()
        {
            Order order;
            if(orders.TryDequeue(out order))
            {
                order.Execute();
            }
        }

        public MenuItem processItem(String orderString)
        {
            switch (orderString)
            {
                case "Burger":
                    return MenuItem.Burger;
                case "Fries":
                    return MenuItem.Fries;
                case "GrilledCheese":
                    return MenuItem.GrilledCheese;
                case "MacNCheese":
                    return MenuItem.MacNCheese;
            }
            return MenuItem.ItemNotAvailable;
        }
    }
}
