using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonMaxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "end")
                {
                    break;
                }
                if (input[0] == "Add")
                {
                    int addPassengers = int.Parse(input[1]);
                    wagons.Add(addPassengers);
                    continue;
                }
                int seatNewPassengers = int.Parse(input[0]);

                for (int i = 0; i < wagons.Count; i++)
                {
                    int leftoverSpace = Math.Abs(wagonMaxCapacity - wagons[i]);
                    if (leftoverSpace >= seatNewPassengers)
                    {
                        wagons[i] += seatNewPassengers;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
