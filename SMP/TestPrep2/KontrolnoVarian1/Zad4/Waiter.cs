using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad4.Commands;

namespace Zad4
{
    class Waiter
    {
        Kitchen kitchen;
        Queue<DeliverOrder> ordersToDeliver = new Queue<DeliverOrder>();

        public Waiter(Kitchen kitchen)
        {
            this.kitchen = kitchen;
        }
        public Kitchen GetKitchen()
        {
            return kitchen;
        }
        public void takeOrder(Order order)
        {
            kitchen.addOrder(order);
        }

        public void takeOrderForDelivery(DeliverOrder deliverOrder)
        {
            ordersToDeliver.Enqueue(deliverOrder);
        }

        public void DeliverItem(Client client, MenuItem item)
        {
            client.recieveItem(item);
        }

        public void Deliverorder()
        {
            DeliverOrder toDeliver;
            if(ordersToDeliver.TryDequeue(out toDeliver))
            {
                toDeliver.Execute();
            }
        }
    }
}
