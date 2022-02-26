using System;

namespace SpaceTravel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] travelRoute = Console.ReadLine().Split(new char[] {'|', ' '}, StringSplitOptions.RemoveEmptyEntries);
            int fuel = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());

            for (int i = 0; i < travelRoute.Length; i += 2)
            {
                string command = travelRoute[i];
                if (command == "Titan")
                {
                    Console.WriteLine($"You have reached Titan, all passengers are safe.");
                    break;
                }
                
                int commandValue = int.Parse(travelRoute[i + 1]);
                if(command == "Travel")
                {
                    if (fuel >= commandValue)
                    {
                        Console.WriteLine($"The spaceship travelled {commandValue} light-years.");
                        fuel -= commandValue;
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        break;
                    }
                }
                else if (command == "Enemy")
                {
                    if (ammunition >= commandValue)
                    {
                        Console.WriteLine($"An enemy with {commandValue} armour is defeated.");
                        ammunition -= commandValue;
                    }
                    else if (fuel >= commandValue * 2 )
                    {
                        Console.WriteLine($"An enemy with {commandValue} armour is outmaneuvered.");
                        fuel -= commandValue * 2;
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        break;
                    }
                }
                else if (command == "Repair")
                {
                    Console.WriteLine($"Ammunitions added: {commandValue * 2}.");
                    Console.WriteLine($"Fuel added: {commandValue}.");
                    fuel += commandValue;
                    ammunition += commandValue * 2;
                }
                
            }

        }
    }
}
