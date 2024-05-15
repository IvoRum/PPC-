using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4.Commands
{
    class DeliverOrder : ICommand
    {
        private Client client;
        private MenuItem item;
        Waiter waiter;

        public DeliverOrder(Client client, MenuItem item, Waiter waiter)
        {
            this.client = client;
            this.item = item;
            this.waiter = waiter;
        }

        public void Execute()
        {
            waiter.DeliverItem(client, item);
        }
    }
}
