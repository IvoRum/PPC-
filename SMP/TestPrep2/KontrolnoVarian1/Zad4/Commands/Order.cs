using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Order : ICommand
    {
        private Waiter waiter;
        private Client client;
        private String order;
        Kitchen kitchen;

        public Order(Waiter waiter,Client client, String order)
        {
            this.waiter = waiter;
            this.client = client;
            this.order = order;
            this.kitchen = waiter.GetKitchen();
        }

        public Waiter GetWaiter()
        {
            return waiter;
        }
        public Client GetClient()
        {
            return client;
        }

        public String getOrderString()
        {
            return order;
        }
        public void Execute()
        {
            waiter.takeOrderForDelivery(new Commands.DeliverOrder(client,kitchen.processItem(order),waiter));
        }
    }
}
