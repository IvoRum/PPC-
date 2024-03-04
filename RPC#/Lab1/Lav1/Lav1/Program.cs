using System;

namespace Lav1
{
    class Program
    {
        static void Main1(string[] args)
        {
            Server s = new Server();
            Client c = new Client();
            c.MyClientMethod(s);
        }
    }

    class Server
    {
        public interface IMyCallback
        {
            void MyCallbackMethod(object state);
            
        }
        public void MyServerMethod(IMyCallback callback)
        {
            // some work
            for (int i = 0; i < 3; i++)
            { // if something interesting happen call the callback
                if (i == 3)
                {
                    callback.MyCallbackMethod(i);
                }
            }
        }
    }
  
    class Client
    {
        private class MyCallback : Server.IMyCallback
        {
            private Client client;
            public MyCallback(Client client)
            {
                this.client = client;
            }

            public void MyCallbackMethod(object state)
            {
                client.Process(state);
            }
        }

        public void MyClientMethod(Server server)
        {
            Server.IMyCallback myCallback = new MyCallback(this);
            server.MyServerMethod(myCallback);
        }

        private void Process(object state)
        {
            Console.WriteLine("The callback is called with value: " + state);
        }

        private void PrintServerName(string serverName)
        {
            Console.WriteLine("Server name is:"+serverName);
        }
    }
}