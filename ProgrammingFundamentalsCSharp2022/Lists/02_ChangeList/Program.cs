using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "end") { break; }
                
                if (input[0] == "Insert")
                {
                    InsertAtIndex(integers, input);
                    continue;
                }
                if (input[0] == "Delete")
                {
                    DeleteAtIndex(integers, input);
                }
            }
            Console.WriteLine(string.Join(" ", integers));
        }

        private static void InsertAtIndex(List<int> integers, string[] input)
        {
            int insertValue = int.Parse(input[1]);
            int insertIndex = int.Parse(input[2]);
            integers.Insert(insertIndex, insertValue);
        }

        private static void DeleteAtIndex(List<int> integers, string[] input)
        {
            int token = int.Parse(input[1]);
            for (int i = integers.Count - 1; i >= 0; i--)
            {
                if (integers[i] == token)
                {
                    integers.Remove(token);
                }
            }
        }
    }
}
