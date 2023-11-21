using System.Reflection.Metadata;

namespace KontrolnoPPC1;

public struct BankAccount
{
    private String _password;
    private String _user;
    private String _accountNumber;
    private BantAccountType _banckAccountType;
    private String _titolqr;
    private float _availability;

    public BankAccount(string password, string user, string accountNumber, BantAccountType banckAccountType, string titolqr, float availability)
    {
        _password = password;
        _user = user;
        _accountNumber = accountNumber;
        _banckAccountType = banckAccountType;
        _titolqr = titolqr;
        _availability = availability;
    }

    public string Password
    {
        get => _password;
        set => _password = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string User
    {
        get => _user;
        set => _user = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string AccountNumber
    {
        get => _accountNumber;
        set => _accountNumber = value ?? throw new ArgumentNullException(nameof(value));
    }

    public BantAccountType BanckAccountType
    {
        get => _banckAccountType;
        set => _banckAccountType = value;
    }

    public string Titolqr
    {
        get => _titolqr;
        set => _titolqr = value ?? throw new ArgumentNullException(nameof(value));
    }

    public float Availability
    {
        get => _availability;
        set => _availability = value;
    }

    public string getTypeAsString()
    {
        switch (_banckAccountType)
        {
            case BantAccountType.Current:
                return "Current";
            case BantAccountType.ForeignCurrency:
                return "Foreign Currency";
        }

        return null;
    }

    public void info()
    {
        Console.WriteLine(this.ToString());
    }

    public override string ToString()
    {
        return "User Name: " + _user + " Holder Name: " + _titolqr + " Account Number: " + _accountNumber +
               " Account Type: " + getTypeAsString() + " Availability: " + _availability.ToString() + "\n";

    }
}