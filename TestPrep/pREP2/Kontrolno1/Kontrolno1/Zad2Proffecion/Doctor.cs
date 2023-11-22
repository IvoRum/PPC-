namespace Kontrolno1;

public class Doctor : Proffecion
{
    private string ambolatorenList;
    private string recepta;

    public override string ToString()
    {
        return base.ToString()+"\n Recepta: "+recepta
               +" ,Ambolatoren Linst: "+ambolatorenList;
    }
    
    public Doctor(string regeon, string specialnost, string egucation, float salary, string ambolatorenList, string recepta) : base(regeon, specialnost, egucation, salary)
    {
        this.ambolatorenList = ambolatorenList;
        this.recepta = recepta;
    }

    public string AmbolatorenList
    {
        get => ambolatorenList;
        set => ambolatorenList = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Recepta
    {
        get => recepta;
        set => recepta = value ?? throw new ArgumentNullException(nameof(value));
    }


}