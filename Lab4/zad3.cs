using System;
/*
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
*/
class Person{   public string Name { get; private set; }
    public Person(string n)
    {  Name = n;    }
}

class Program   //използване на класа 
{   static void Main(string[] args)
    {   Person person = new Person();
        Console.WriteLine(person.Name); // Tom
        Console.WriteLine(person.Age);  // 23   
        
    }
} 

