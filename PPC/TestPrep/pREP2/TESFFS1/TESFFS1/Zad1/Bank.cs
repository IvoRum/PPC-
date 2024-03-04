namespace KontrolnoPPC1;

public class Bank
{
    private BankAccount[] _bankAccounts;

    public Bank()
    {
        List<BankAccount> accounts = new List<BankAccount>();
        accounts.Add(new BankAccount("123","Ivan","123213",BantAccountType.Current,"IvanGekovGanchev",312312));
        _bankAccounts = accounts.ToArray();
    }

    public void printAccoutnInfo()
    {
        foreach (var VARIABLE in _bankAccounts)
        {
            VARIABLE.info();
        }
    }
}