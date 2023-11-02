using System;
public class Person
{   private string mName;
    private DateTime mDateOfBirth;
    // Property Name of type string
    public string Name
    {   get
        { return mName; }
        set
        {   if ((value != null) && (value.Length > 0))
            { mName = value; }
            else
            {
                throw new ArgumentException("Invalid name!");
            }
        }
    }

    // Property DateOfBirth of type DateTime
    public DateTime DateOfBirth
    {   get { return mDateOfBirth; }
        set
        {   if ((value.Year >= 1900) && (value.Year <= DateTime.Now.Year))
            {
                mDateOfBirth = value;
            }
            else
            {
     throw new ArgumentOutOfRangeException("Invalid date of birth!");
            }
        }
    }
    // Read-only property Age of type int
    public int Age
    {   get
        {   DateTime now = DateTime.Now;
            int yearsOld = now.Year - mDateOfBirth.Year;
            return yearsOld;
        }
    }
}
class Program
{    static void Main()
    {   Person p = new Person();
        p.Name = "Ivan Ivanov";
        p.DateOfBirth = new DateTime(1980, 5, 14);
        Console.WriteLine("{0} is born on {1:dd.MM.yyyy}.",
            p.Name, p.DateOfBirth);
        Console.WriteLine("{0} is {1} years old.", p.Name, p.Age);
        Console.ReadLine();
    }
}
