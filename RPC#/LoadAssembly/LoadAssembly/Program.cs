using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.load();
        }
        public void load()
        {
            Assembly assembly = Assembly.LoadFrom(@"C:\Users\IvoRakitin\Documents\Visual Studio 2017\Projects\ConsoleApp13\ConsoleApp13\bin\Debug\ConsoleApp12.dll");
            Type type = assembly.GetType("ConsoleApp12.Person");
            Type myCustomAttributeType = assembly.GetTypes().FirstOrDefault(t => t.Name == "SuperVisor");
            Console.WriteLine("My custom: " + myCustomAttributeType.ToString());
            if (myCustomAttributeType != null)
            {
            // Iterate through types and check for attributes dynamically
                // Check if the type has any custom attributes
                object[] attributes = type.GetCustomAttributes(myCustomAttributeType, false);

                if (attributes.Length > 0)
                {
                    // Access attribute properties dynamically
                    //For one property
                    //PropertyInfo descriptionProperty = myCustomAttributeType.GetProperty("Name");

                    PropertyInfo[] descriptionProperty = myCustomAttributeType.GetProperties();
                    for (int i = 0; i < descriptionProperty.Length - 1; i++)
                    {
                        foreach (var attribute in attributes)
                        {
                            string description = (string)descriptionProperty[i].GetValue(attribute);
                            Console.WriteLine($"Type: {type.FullName}");
                            Console.WriteLine($"Description: {description}");
                            Console.WriteLine();
                        }
                    }
                }
            }
            /*
            Type[] types = assembly.GetTypes();

            
            for (int i = 0; i < types.Length; i++)
            {
                Type myCustomAttributeType = assembly.GetTypes().FirstOrDefault(t => t.Name == "Author");
                Console.WriteLine("My custom: " + myCustomAttributeType.ToString());

                if (myCustomAttributeType != null)
                {
                    // Iterate through types and check for attributes dynamically
                    foreach (Type t in types)
                    {
                        // Check if the type has any custom attributes
                        object[] attributes = t.GetCustomAttributes(myCustomAttributeType, true);

                        if (attributes.Length > 0)
                        {
                            // Access attribute properties dynamically
                            PropertyInfo descriptionProperty = myCustomAttributeType.GetProperty("Name");
                            foreach (var attribute in attributes)
                            {
                                string description = (string)descriptionProperty.GetValue(attribute);
                                Console.WriteLine($"Type: {t.FullName}");
                                Console.WriteLine($"Description: {description}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }*/

            /*
            Console.WriteLine();
            Type type = assembly.GetType("ConsoleApp12.Person");
            object[] customAttributes = type.GetCustomAttributes(false);
            
            for (int i = 0; i < customAttributes.Length; i++)
            {
                object temp = customAttributes[i];
                Console.WriteLine(temp.ToString());
            }*/
        }
    }
}
