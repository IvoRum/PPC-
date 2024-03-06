namespace zad2;

public class ThirdPartyBillingSystem
{
    private ITarget employeeSource;

    public ThirdPartyBillingSystem(ITarget employeeSource)  
    { 
        this.employeeSource = employeeSource; 
    }

    public void ShowEmployeeList()
    {
        List<string> employee = employeeSource.GetEmployeeList();
        foreach (var item in employee)
        {
            Console.Write(item);
        }
    }
}