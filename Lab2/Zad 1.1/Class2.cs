using System;
using System.Globalization;
namespace Types
{class Class1
	{static void Main()
		{	//Предполага се, че текущата култура "bg-BG"
			
		  Console.WriteLine("\"C\" Format: en-US {0,14:C}", 12345.678);
//Установяване на нова култура - в System.Globalization;
			CultureInfo ct = new CultureInfo("en-US");
			Console.WriteLine("\"C\" Format: en-US {0,14}", (12345.678).ToString("C", ct));
			Console.WriteLine("\"D\" Format:{0,14:D}", 123);
			Console.WriteLine("\"E\" Format:{0,14:E} ", 12345.6789);
			Console.WriteLine("\"G\" Format:{0,14:G} ", 12345.6789);
			Console.WriteLine("\"N\" Format:{0,14:N} ", 12345.6789);
			Console.WriteLine("\"X\" Format:{0,14:X} ", 1234);
			Console.WriteLine("\"P\" Format:{0,14:P} ", 0.9);
			Console.ReadLine();
		}
	}
}
