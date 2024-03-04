using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lav2
{
    class Program
    {
        static void Main(string[] args)
        {
            Server s = new Server();
            Client c = new Client();
            c.MyClientMethod(s);
        }
    }

    class Server
    {
        private string servername = "Server";
        public delegate void MyCallBack(object state, int a);

        public void MyServerMethod(MyCallBack callback)
        {
            //some work
            for (int i = 0; i < 200; i++)
            {
                if (i == 100)
                {
                    //callback.Invoke(this, i);
                    callback(this, i);
                }
            }
        }

        public string getServerName()
        {
            return servername;
        }
    }

    class Client
    {
        public void MyClientMethod(Server s)
        {
            Server.MyCallBack myCallback = new Server.MyCallBack(Process);
            s.MyServerMethod(myCallback);
        }

        private void Process(object state, int a)
        {
            Console.WriteLine("The callback from {0} is called with state {1}!", ((Server)state).getServerName(), a);
        }
    }
}