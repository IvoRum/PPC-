namespace Zad4Turisum;

public class Kurs
{
    private string pertisipanteName;
    private string contry;
    private string price;
    private Theme theme;

    public Kurs(string pertisipanteName,string contry, string price, Theme theme)
    {
        this.pertisipanteName = pertisipanteName;
        this.contry = contry;
        this.price = price;
        this.theme = theme;
    }

    public string Contry
    {
        get => contry;
        set => contry = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Price
    {
        get => price;
        set => price = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Theme Theme
    {
        get => theme;
        set => theme = value;
    }

    public string PertisipanteName
    {
        get => pertisipanteName;
        set => pertisipanteName = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public Kurs ShallowCopy()
    {
        return (Kurs)this.MemberwiseClone();
    }

    public override string ToString()
    {
        return "Your Name: "+pertisipanteName+
            " Contry: "+contry+
            " Price: "+price+
            " Theme: "+theme;
    }
}