namespace Lab17Mediator;

public abstract class Colleague
{
    private Mediator mediator;
    
    public Colleague(Mediator mediator) 
    {this.mediator = mediator;}
    
    public void Send(string message) {mediator.Send(message, this); }

    public abstract void Notify(string message);
}