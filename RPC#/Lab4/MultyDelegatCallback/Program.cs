namespace MultyDelegatCallback;

class Program
{
    static void Main(string[] args)
    {
        Server s = new Server();
        Client c = new Client();
        c.MyClientMethod(s);
        Console.ReadKey();
    }
}

class Server
{
    private string servername = "Server";
    public delegate void MyCallBack(object state, int a);

    public void MyServerMethod(MyCallBack callback)
    {
        //some work
        Delegate[] callbacklist = callback.GetInvocationList();
        for (int i = 0; i < 20; i++)
        {
            if (i == 8)
            {
                //callback.Invoke(this, i);
                //callback(this, i);
                if (callbacklist[0].GetType() == typeof(MyCallBack))
                    ((MyCallBack)callbacklist[0])(this, i);
            }
            else if(i == 12)
            {
                if (callbacklist[1].GetType() == typeof(MyCallBack))
                    ((MyCallBack)callbacklist[1])(this, i);
            }
            else if (i == 16)
            {
                if (callbacklist[2].GetType() == typeof(MyCallBack))
                    ((MyCallBack)callbacklist[2])(this, i);
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
        Server.MyCallBack myCallback1 = new Server.MyCallBack(Process);
        Server.MyCallBack myCallback2 = new Server.MyCallBack(Execute);
        Server.MyCallBack myCallback3 = new Server.MyCallBack(Finalise);
        s.MyServerMethod(myCallback1 + myCallback2 + myCallback3);
    }

    private void Process(object state, int a)
    {
        Console.WriteLine("The Process callback from {0} is called with state {1}!", ((Server)state).getServerName(), a);
    }

    private void Execute(object state, int a)
    {
        Console.WriteLine("The Execute callback from {0} is called with state {1}!", ((Server)state).getServerName(), a);
    }

    private void Finalise(object state, int a)
    {
        Console.WriteLine("The Finalise callback from {0} is called with state {1}!", ((Server)state).getServerName(), a);
    }
}