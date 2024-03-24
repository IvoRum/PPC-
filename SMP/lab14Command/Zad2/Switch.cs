using System.Windows.Input;

namespace Zad2;

public class Switch
{
    private List<Icommand> _commands = new List<Icommand>();

    public void StoreAndExecute(Icommand command)
    {
        _commands.Add(command); command.Execute();
        
    }

    public Switch()
    {
    }
}