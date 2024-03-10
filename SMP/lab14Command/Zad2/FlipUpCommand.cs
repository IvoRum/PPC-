namespace Zad2;

public class FlipUpCommand : Icommand
{
    private Light _light;

    public FlipUpCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOn();
    }
}