using PPC_Dom7.Zad2;

class Program
{
    static void Main(string[] args)
    {
        EmployeeLIst list = new EmployeeLIst();
        list.AddEmployee(new Employee("Mityo",1, DateTime.Now.AddDays(4)));
        list.AddEmployee(new Employee("Daniel", 4, DateTime.Now.AddDays(3)));
        list.AddEmployee(new Employee("Baldar", 3, DateTime.Now.AddDays(2)));
        list.AddEmployee(new Employee("Lilqna", 2, DateTime.Now.AddDays(2)));
        list.PrintSortedList();
        Console.WriteLine(list.FindEmployee("Baldar").ToString());
        Console.WriteLine(list.HighestLevelEmployee());
        list.RemoveEmployee(list.FindEmployee("Daniel"));
        list.PrintSortedList();
    }
}