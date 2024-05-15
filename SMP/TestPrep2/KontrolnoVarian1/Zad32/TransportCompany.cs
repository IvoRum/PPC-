namespace Zad32;

public class TransportCompany
{
    private IStrategyTransport _transport;

    public TransportCompany()
    { }

    public TransportCompany(IStrategyTransport transport)
    {
        _transport = transport;
    }

    public void runTransport(Pasenger person)
    {
        _transport.transpost(person);
    }
}