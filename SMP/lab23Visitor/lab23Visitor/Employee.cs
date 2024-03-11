namespace lab23Visitor;

public class Employee:Element
{
    private string _name; 
    private double _income; 
    private int _vacationDays;

    public Employee(string name, double income, int vacationDays)
    {
        _name = name;
        _income = income;
        _vacationDays = vacationDays;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Income
    {
        get => _income;
        set => _income = value;
    }

    public int VacationDays
    {
        get => _vacationDays;
        set => _vacationDays = value;
    }
    
    public override void Accept (Ivisitor visitor){
        visitor.Visit(this); } 
}