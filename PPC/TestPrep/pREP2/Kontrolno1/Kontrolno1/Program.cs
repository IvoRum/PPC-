using System;
using Kontrolno1.KR2;
using Kontrolno1.KR2Zad2;

namespace Kontrolno1;

class Program
{
    static void Main(string[] args)
    {
        Bank bank=new Bank();
        bank.info();
        
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

        Student student1 = new Student("Ivan", "Zlatarov");
        Student student2 = new Student("Katq", "Ilieva");
        Student student3 = new Student("Mariq", "Ilieva");
        Student student4 = new Student("Kaloqn", "Ivanov");
        Student student5 = new Student("Lora", "Ignatova");

        List<Student> students = new List<Student>();
        students.Add(student1);
        students.Add(student2);
        students.Add(student3);
        students.Add(student4);
        students.Add(student5);

        StudentGroup group1 = new StudentGroup("1a", "SI", students);

        Prepodavatel prepodavatel = new Prepodavatel("Ivan", "Ivanov", new List<StudentGroup>(){group1});
        
        University tuvarna = 
            new University("TY Varna",new List<Prepodavatel>(){prepodavatel},
                new List<StudentGroup>(){group1},students
                );

        tuvarna.printPrepodavatels();

        FileZad fileZad = new FileZad();
        fileZad.readFile();
    }
}
