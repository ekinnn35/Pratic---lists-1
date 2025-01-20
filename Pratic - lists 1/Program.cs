using System;
using System.Collections.Generic;

namespace PatikaGala
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store guest names
            List<string> guestList = new List<string>();

            // Get 5 guest names from the user
            Console.WriteLine("Enter the names of the guests for the Patika Plus Gala Night:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Guest {i + 1}: ");
                string name = Console.ReadLine();
                guestList.Add(name);
            }

            // Print the guest list
            Console.WriteLine("\nGuests attending the gala night:");

            foreach (string guest in guestList)
            {
                Console.WriteLine($"- {guest}");
            }

            Console.WriteLine("\nAll guests have been successfully listed.");
        }
    }
}