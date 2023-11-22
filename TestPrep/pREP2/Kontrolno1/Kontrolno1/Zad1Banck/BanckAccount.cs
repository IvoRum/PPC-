namespace Kontrolno1;

public struct BanckAccount
{
    private string password;
    private string user;
    private string banckAccountNumber;
    private  BanckAccountType type;
    private string fullName;
    private float availability;

    public override string ToString()
    {
        return "User: " + user + ", Password: " + password
               + "BankAcountNumber: " + banckAccountNumber
               + "Full name: " + fullName + "Availiabity: " + availability.ToString()
               +"Type: "+ accountTypeToString();
    }

    public void info()
    {
        Console.WriteLine(this.ToString());
    }

    public string Password
    {
        get => password;
        set => password = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string User
    {
        get => user;
        set => user = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string BanckAccountNumber
    {
        get => banckAccountNumber;
        set => banckAccountNumber = value ?? throw new ArgumentNullException(nameof(value));
    }

    public BanckAccountType Type
    {
        get => type;
        set => type = value;
    }

    public string FullName
    {
        get => fullName;
        set => fullName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public float Availability
    {
        get => availability;
        set => availability = value;
    }

    public BanckAccount(string password, string user, string banckAccountNumber, BanckAccountType type, string fullName, float availability)
    {
        this.password = password;
        this.user = user;
        this.banckAccountNumber = banckAccountNumber;
        this.type = type;
        this.fullName = fullName;
        this.availability = availability;
    }

    public string accountTypeToString()
    {
        switch (type)
        {
            case BanckAccountType.currentCurrency:
                return "Current Currency";
            case BanckAccountType.foreignCurrency:
                return "Foreign Currentsy";
            
        }

        return null;
    }


}