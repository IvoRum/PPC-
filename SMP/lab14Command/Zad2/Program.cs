using Zad2;

public class Manager
{
    static void Main()
    {
        Console.WriteLine("nter Commands (ON/OFF) ");
        string cmd = Console.ReadLine();
        Light lamp = new Light();

        Icommand switchUp = new FlipUpCommand(lamp);

        Icommand switchDown = new FlipDownCommand(lamp);

        Switch s = new Switch();

        if (cmd == "ON")
        {
            s.StoreAndExecute(switchUp);
        }
        else if (cmd == "OFF")
        {
            {
                s.StoreAndExecute(switchDown);
            }
        }
    }
}