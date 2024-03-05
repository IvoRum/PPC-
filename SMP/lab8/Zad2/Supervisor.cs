namespace Zad2;

public class Supervisor : IEmployee
{
    private string name;
    private int happiness;
    private List<IEmployee> subordinate = new List<IEmployee>();

    public Supervisor(string name, int happiness)
    {
        this.name = name;
        this.happiness = happiness;
    }

    public void ShowHappiness()
    {
        Console.WriteLine(name + " showed happiness level of " + happiness);
        foreach (IEmployee i in subordinate)
        {
            i.ShowHappiness();
        }
    }

    public void AddSubordinate(IEmployee employee)
    {
        subordinate.Add(employee);
    }
}