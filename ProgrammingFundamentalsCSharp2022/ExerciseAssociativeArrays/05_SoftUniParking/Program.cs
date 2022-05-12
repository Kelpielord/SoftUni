using System;
using System.Collections.Generic;

namespace _05_SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> registeredCars = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                string driverName = input[1];

                if (command == "register")
                {
                    if (!registeredCars.ContainsKey(driverName))
                    {
                        string plateNumber = input[2];
                        registeredCars.Add(driverName, plateNumber);
                        Console.WriteLine($"{driverName} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registeredCars[driverName]}");
                    }
                }
                
                if (command == "unregister")
                {
                    if (registeredCars.ContainsKey(driverName))
                    {
                        registeredCars.Remove(driverName);
                        Console.WriteLine($"{driverName} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {driverName} not found");
                    }
                }
            }
            foreach (var driver in registeredCars)
            {
                Console.WriteLine($"{driver.Key} => {driver.Value}");
            }
        }
    }
}
