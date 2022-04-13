using System;
using System.Collections.Generic;

namespace _02_AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> recources = new Dictionary<string, int>();
            int evenOrOddCounter = 0;
            string currentRecource = null;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                evenOrOddCounter++;

                if (evenOrOddCounter % 2 == 1)
                {
                    currentRecource = input;
                    if (!recources.ContainsKey(currentRecource))
                    {
                        recources.Add(currentRecource, 0);
                    }
                }
                else if (evenOrOddCounter % 2 == 0)
                {
                    recources[currentRecource] += int.Parse(input);
                }
            }
            foreach (var recource in recources)
            {
                Console.WriteLine($"{recource.Key} -> {recource.Value}");
            }
        }
    }
}
