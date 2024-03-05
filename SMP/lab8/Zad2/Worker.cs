namespace Zad2;

public class Worker:IEmployee
{
    private string name;
    private int happiness;

    public Worker(string name, int happiness)
    {
        this.name = name;
        this.happiness = happiness;
    }

    public void ShowHappiness()
    {
        throw new NotImplementedException();
    }

    void IEmployee.ShowHappiness()
    {
        Console.WriteLine(name + " showed happiness level of " + happiness); 
    }
}