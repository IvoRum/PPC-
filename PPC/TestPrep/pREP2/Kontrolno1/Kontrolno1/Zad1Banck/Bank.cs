namespace Kontrolno1;

public class Bank
{
    private BanckAccount[] _banckAccounts;

    public Bank()
    {
        List<BanckAccount> banckAccounts = new List<BanckAccount>();
        banckAccounts.Add(new BanckAccount("12345678","Ivan","kfo33246",BanckAccountType.currentCurrency,"Ivan iBrahimovich naskov",10000001));
        banckAccounts.Add(new BanckAccount("qwertyuiop","Katq","dfjh784",BanckAccountType.foreignCurrency,"Kqt[ Nikolaeva nikolova",1));
        banckAccounts.Add(new BanckAccount("57898656","Mitko","jkk8789876",BanckAccountType.currentCurrency,"Mitko Mitkov Mitovski",7687));
        _banckAccounts = banckAccounts.ToArray();

    }

    public void info()
    {
        foreach (var VARIABLE in _banckAccounts)
        {
            VARIABLE.info();
        }
    }
}