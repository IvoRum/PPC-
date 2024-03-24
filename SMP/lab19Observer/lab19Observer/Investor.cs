namespace lab19Observer;

public class Investor:Iinvestor
{
    string _name; 
    Stock _stock;

    public Investor(string name)
    {
        _name = name;
    }

    public void Update(Stock stock)
    {
        Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", _name, stock.Symbol, stock.Price);
    }
}