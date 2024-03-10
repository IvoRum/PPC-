namespace Zad2;

public class FlipDownCommand : Icommand
{
    Light _light;

    public void Execute()
    {
        _light.TurnOff();
    }

    public FlipDownCommand(Light light)
    {
        _light = light;
    }
}