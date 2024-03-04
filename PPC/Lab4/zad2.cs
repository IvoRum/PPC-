using System;
namespace employe1
{   class employee
    {
//достъп protected – членовете са достъпни за класа и неговите наследници
        protected string firstname;
        protected string lastname;
        protected int age;
        protected double payrate;
        //Конструктор
public employee(string firstname, string lastname, int age, double payrate)
        {   this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.payrate = payrate;
        }
//Препокриване на ToString()- виртуален метод на System.Object 
public override string ToString()
    {   return "Name:"+firstname + " " + lastname + "\tAge:" + age;
    }
        //Метод calculatepay - virtual
        public virtual double calculatepay(int hoursworked)
        //полиморфизъм
        {   
Console.WriteLine("\nThis is the base class method for calculating salary!");
            Console.WriteLine(this.ToString());
            payrate = payrate * (double)hoursworked;
            return payrate;
        }
    }//Край на клас employee
    //definirane na naslednik salariedemployee
    class salariedemployee : employee
    {   //Конструктор
public salariedemployee(string firstname, string lastname, int age, double payrate) : base(firstname, lastname, age, payrate) { }
        //Метод calculatepay - override
        public override double calculatepay(int hoursworked) //override
        {//Изчисляване заплатата на работника по друга формула
Console.WriteLine("\nThis is the override method for calculating salary!");
            Console.WriteLine("{0} {1},{2}", firstname, lastname, age);
            payrate = payrate * (double)hoursworked * 1.2;
            return payrate;
        }
        
    }

    class Program
    {     static void Main(string[] args)
        {   employee emp;
            emp = new employee("Elena", "Ivanova", 34, 100);
            Console.WriteLine("\nSalary=" + emp.calculatepay(40) + "\n");
            salariedemployee empsal;
            empsal = new salariedemployee("Bozhidar", "Stoev", 49, 200);
        Console.WriteLine("\nSalary=" + empsal.calculatepay(40) + "\n");
            Console.ReadLine();
        }
    }
}
