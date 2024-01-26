using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> nameSsnDictionary = new Dictionary<string, string>();

        nameSsnDictionary.Add("John Doe", "123456789");
        nameSsnDictionary.Add("Jane Smith", "987654321");
        nameSsnDictionary.Add("Bob Johnson", "555112233");

        PrintCollection(nameSsnDictionary);

        Console.Write("\nEnter a social security number to search: ");
        string ssnToSearch = Console.ReadLine();

        if (SearchBySsn(nameSsnDictionary, ssnToSearch, out string foundName))
        {
            Console.WriteLine($"Found: {foundName} - {ssnToSearch}");
        }
        else
        {
            Console.WriteLine($"Social Security Number {ssnToSearch} not found.");
        }

        // Search for a social security number
        Console.Write("\nEnter a social security number or name to remove: ");
        string inputToRemove = Console.ReadLine();

        if (RemoveEntry(nameSsnDictionary, inputToRemove, out string removedName, out string removedSsn))
        {
            Console.WriteLine($"Removed: {removedName} - {removedSsn}");
        }
        else
        {
            Console.WriteLine($"No entry found with the input: {inputToRemove}");
        }
        
        PrintCollection(nameSsnDictionary);
        
        Console.ReadLine();
    }

    private static void PrintCollection(Dictionary<string, string> nameSsnDictionary)
    {
        Console.WriteLine("Name\t\t\tSocial Security Number");
        Console.WriteLine("-------------------------------------------");
        foreach (var entry in nameSsnDictionary)
        {
            Console.WriteLine($"{entry.Key}\t\t{entry.Value}");
        }
    }

    // Function to remove an entry by either name or social security number
    static bool RemoveEntry(Dictionary<string, string> dictionary, string inputToRemove, out string removedName, out string removedSsn)
    {
        foreach (var entry in dictionary)
        {
            if (entry.Key.Equals(inputToRemove, StringComparison.OrdinalIgnoreCase) || entry.Value.Equals(inputToRemove))
            {
                removedName = entry.Key;
                removedSsn = entry.Value;
                dictionary.Remove(entry.Key);
                return true;
            }
        }

        removedName = null;
        removedSsn = null;
        return false;
    
    }

    // Function to search for a social security number in the dictionary
    static bool SearchBySsn(Dictionary<string, string> dictionary, string ssn, out string foundName)
    {
        foreach (var entry in dictionary)
        {
            if (entry.Value == ssn)
            {
                foundName = entry.Key;
                return true;
            }
        }

        foundName = null;
        return false;
    }
}
