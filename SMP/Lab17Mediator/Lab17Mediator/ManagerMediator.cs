namespace Lab17Mediator;

public class ManagerMediator:Mediator
{
    public Colleague Customer { get; set; }

    public Colleague Programmer { get; set; }

    public Colleague Tester { get; set; }

    public override void Send(string msg, Colleague colleague)
    {
        if (Customer == colleague) Programmer.Notify(msg);
        if (Programmer == colleague) Tester.Notify(msg);
        if (Tester == colleague) Customer.Notify(msg);

    }
}