namespace Lab17Mediator;

public class TesterColleague:Colleague
{
    public TesterColleague(Mediator mediator): base(mediator){}

    public override void Notify(string message)
    {
        Console.WriteLine("Съобщение тестер: " + message);
    }
}