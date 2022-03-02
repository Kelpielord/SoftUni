using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split();
                if (commands[0] == "End")
                {
                    break;
                }

                if (commands[0] == "Add")
                {
                    AddNumber(integers, int.Parse(commands[1]));
                }
                else if (commands[0] == "Remove")
                {
                    RemoveAtIndex(integers, int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    InsertAtIndex(integers, int.Parse(commands[1]), int.Parse(commands[2]));
                }
                else if (commands[0] == "Shift")
                {
                    ShiftNumbers(integers, commands[1], int.Parse(commands[2]));
                }
            }
            Console.WriteLine(string.Join(" ", integers));
        }

        private static void ShiftNumbers(List<int> integers, string direction, int rotationCount)
        {
            if (direction == "left")
            {
                ShiftNumbersLeft(integers, rotationCount);
            }
            else if (direction == "right")
            {
                ShiftNumbersRight(integers, rotationCount);
            }
        }

        private static void ShiftNumbersRight(List<int> integers, int rotationCount)
        {
            for (int i = 0; i < rotationCount; i++)
            {
                integers.Insert(0, integers[integers.Count - 1]);
                integers.RemoveAt(integers.Count - 1);
            }
        }

        private static void ShiftNumbersLeft(List<int> integers, int rotationCount)
        {
            for (int i = 0; i < rotationCount; i++)
            {
                integers.Add(integers[0]);
                integers.RemoveAt(0);
            }
        }

        private static void InsertAtIndex(List<int> integers, int value, int index)
        {
            if (index <= integers.Count)
            {
                integers.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        private static void RemoveAtIndex(List<int> integers, int index)
        {
            if (index > integers.Count)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            integers.RemoveAt(index);
        }

        private static void AddNumber(this List<int> integers, int number)
        {
            integers.Add(number);
        }
    }
}
