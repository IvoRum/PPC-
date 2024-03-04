using PPC_dom5.Zad_2;
using PPC_dom5.Zad3;
using PPC_dom5.Zad4;
using System;

namespace PPC_dom5
{
    class Program
    {
        static void Main(string[] args)
        {
			//Zad1 
			Office o1 = new Office();
			o1.Building = 118;
			o1.Room = 3306;
			o1.Size = 98;
			Office o2= new Office();
			o2.Building = 118;
			o2.Room = 2245;
			o2.Size = 144;
			//Print out hash codes
			Console.WriteLine("o1 hash = {0}, o2 hash = {1}", o1.GetHashCode(), o2.GetHashCode());
			//Print out string representations
			Console.WriteLine("o1 string = {0}, o2 string = {1}", o1.ToString(), o2.ToString());
			//Are they equal?
			if (o1 == o2) Console.WriteLine("o1 is equal to o2");
			else Console.WriteLine("o1 is not equal to o2");

			//Convert to office unit
			OfficeUnit ou = (OfficeUnit)o1;
			Console.WriteLine("Office Building Number: {0}", ou.Building);
			Console.WriteLine("Office Room Number: {0}", ou.Room);
			Console.WriteLine("Office Unit Size: {0}", ou.Size);

			//Zad 2
			Box box1 = new Box(3,4);
			Console.WriteLine(box1.length() + " / " + box1.width());
			IDimensions dimens = new Box((float)3.6, (float)4.9);
			Console.WriteLine(dimens.length() + " / " + dimens.width());
			Console.WriteLine("\n");

			//Zad 3 

			Rectangle rect1 = new Rectangle(30, 44);
			IEnglishDimensions eng1 = rect1;
			IMetricDimensions met1 = rect1;
			Console.WriteLine("Lenght (in): {0}", eng1.length());
			Console.WriteLine("Width (in): {0}", eng1.width());
			Console.WriteLine("Lenght (cm): {0}", met1.length());
			Console.WriteLine("Width (cm): {0}", met1.width());

			//Zad 4
			Client cl1 = new Client("Mike",2314, 9);
			Console.WriteLine("Client " + cl1.Name + "\n");
			Console.WriteLine("Initial " + cl1.Ammount + "\n");
			Console.WriteLine("Interest " + cl1.InterestPercent + "\n");
			cl1.deposit(5312);
			Console.WriteLine("Deposit 5312 \n");
			cl1.withdraw(4783);
			Console.WriteLine("Withdraw 4783 \n");
			Console.WriteLine(cl1.Name + " Now has " + cl1.Ammount + "\n");

		}
	}
}
