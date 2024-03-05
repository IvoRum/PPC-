namespace Zad3Balansator;

public class Balancer
{
    private static Balancer instance = null;
    private List<Server> Servers;
    
    private Balancer()
    {
    }
    
    public static Balancer GetInstance()
    { 
        if (instance == null) 
        {
                instance = new Balancer();
        } 
        return instance;
    }

    void sendMessage(string ms)
    {
        int lowestWorkFlow=0;
        Server serverWhitHiestWorkFlow=new Server();
        foreach (var server in Servers)
        {
            if (lowestWorkFlow <server.WorkFlow1)
            {
                serverWhitHiestWorkFlow = server;
            }
        }
        serverWhitHiestWorkFlow.work(ms);
    }
}