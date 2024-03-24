namespace lab19Observer;

public abstract class Stock
{
    string _symbol;
    double _price;

    private List<Iinvestor> _investors = new List<Iinvestor>();

    protected Stock(string symbol, double price)
    {
        _symbol = symbol;
        _price = price;
    }
    
    public void Attach(Iinvestor investor)    {_investors.Add(investor);} 
    
    public void Detach(Iinvestor investor) { _investors.Remove(investor);}

    void Notify()
    {
        foreach (Iinvestor investor in _investors) { investor.Update(this); } 
        
    }

    public double Price
    {
        get { return _price; }
        set
        {
            if (_price != value)
            {
                _price = value;
                Notify();
            }
        }
    }

    public string Symbol
    {
        get { return _symbol; }
    }
}