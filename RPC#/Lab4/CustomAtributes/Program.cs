// See https://aka.ms/new-console-template for more information

namespace MyNamespace
{
[AttributeUsage(AttributeTargets.Class)]
class Author : Attribute
{
    public string Name
    {
        get; set;
    }
    public string Email
    {
        get; set;
    }

    public Author(string name, string email)
    {
        Name = name;
        Email = email;
    }
}

[AttributeUsage(AttributeTargets.Class)]
class SuperVisor : Attribute
{
    public string Name
    {
        get; set;
    }
    public SuperVisor(string name)
    {
        Name = name;
    }
}

[Author("John Doe", "root@localhost")]
[SuperVisor("Your boss!")]
class Person
{
}

class Program
{
    public static void Main(string[] args)
    {
        // get all custom attributes of the Person class
        Attribute[] attributes = Attribute.GetCustomAttributes(typeof(Person));

        // Retrieve the author attribute
        Author author = attributes.OfType<Author>().Single();
        SuperVisor supervisor = attributes.OfType<SuperVisor>().Single();
        Console.WriteLine("Author name:{0} autor email:{1}", author.Name, author.Email);
        Console.WriteLine("Supervisor name: {0}", supervisor.Name);
    }
}
}