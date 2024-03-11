namespace lab23Visitor;

public class Employees
{
    private List<Employee> _employees = new List<Employee>();

    public void Attach(Employee employee)
    {
        _employees.Add(employee);
    }

    void Detach(Employee employee)
    {
        _employees.Remove(employee);
    }

    public void Accept(Ivisitor visitor)
    {
        foreach (Employee e in _employees)
        {
            e.Accept(visitor);
        }
    }
}