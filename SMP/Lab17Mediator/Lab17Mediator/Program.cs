using Lab17Mediator;

public class Program
{
    public static void Main()
    {
        ManagerMediator mediator = new ManagerMediator(); 
        Colleague customer = new CustomerColleague(mediator); 
        Colleague programmer = new ProgrammerColleague(mediator); 
        Colleague tester = new TesterColleague(mediator); 
        mediator.Customer = customer; 
        mediator.Programmer = programmer; 
        mediator.Tester = tester; 

        customer.Send("Има задание, необходимо е да се създаде програма"); 
        programmer.Send("Програмата е готова, трябва да се тества"); 
        tester.Send("Програмата е тествана и е готова за продажба"); 
    }
}