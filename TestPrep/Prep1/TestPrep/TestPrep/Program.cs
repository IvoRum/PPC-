using System;

namespace KontrolnoPPC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank1 = new Bank();
            bank1.PrintAccountsInfo();

            Console.WriteLine("Available Professions: \n" +
                "1 Teacher \n" + "2 Doctor \n");
            while (true)
            {
                String input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Teacher teacher = new Teacher("Class 12", "History", "Teaching", "History", "Masters Degree", 1800);
                        Console.WriteLine(teacher.ToString());
                        break;
                    case "2":
                        Doctor doctor = new Doctor("Ambulatory List 1", "Perscription 1", "Medicine", "Cardiology", "MD", 3200);
                        Console.WriteLine(doctor.ToString());
                        break;
                    default:
                        Console.WriteLine("Invalid input \n");
                        break;

                }
            }
        }
    }
}
