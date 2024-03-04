using System;
using Kontrolno1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Available Professions: \n" +
                          "1 Teacher \n" + "2 Doctor \n");
        String input;
        do
        {
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Teacher teacher = new Teacher("Shumen", "Himiq", "Viche", 1200, "Himiq", "5A");
                    Console.WriteLine(teacher.ToString());
                    break;
                case "2":
                    Doctor doctor = new Doctor("varna", "Ochen", "Viche", 1800, "Mnogo bolen si", "Aspirin");
                    Console.WriteLine(doctor.ToString());
                    break;
                default:
                    Console.WriteLine("Invalid input \n");
                    break;

            }
        } while (input != "3");
    }
}