// See https://aka.ms/new-console-template for more information


using Zad1;

public class Manager
{
    static void Main()
    {
        Programmer freelancer = new FreelanceProgrammer(new CPPLanguage());
        freelancer.Language = new CsharpLanguage(); 
        freelancer.DoWork();
        freelancer.EarnMoney();
    }
}