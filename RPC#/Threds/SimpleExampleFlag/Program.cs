class Program
{
    static void Main(string[] args)
    {
        MyThread mt = new MyThread();
        mt.GetThread().Start();
        while (MyThread.Counter < 20 && MyThread.Counter > 0)
        {
            if ((MyThread.Counter % 10) == 0)
            {
                Console.WriteLine("Stop request!");
                mt.Stop();
            }
        }
    }
}

public class MyThread
{
    private ManualResetEvent terminate = new ManualResetEvent(false);
    private Thread thread;
    public static int Counter = 1;
    private static int SleepTime = 200;
    private void PollingThread()
    {
        // do your stuff, if you want a pause after each loop,
        // you should change the 0 of waitone. This way the 
        // termination isn't blocked when waiting
        for (Counter = 1; Counter <= 20; Counter++)
        {
            Console.WriteLine("Iteration {0}", Counter);
            Thread.Sleep(SleepTime);

            if (terminate.WaitOne(0))
            {
                Counter = 0;
                Console.WriteLine("Counter: {0}", Counter);
                break;
            }
        }
    }

    public MyThread()
    {
        thread = new Thread(PollingThread);
    }

    public void Stop()
    {
        if (thread != null)
        {
            terminate.Set();
            thread.Join();
            thread = null;
        }
    }

    public Thread GetThread()
    {
        return thread;
    }
}