using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groupOfNums = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<int> rotatedList = new List<int>();
            groupOfNums.Reverse();

            foreach (string group in groupOfNums)
            {
                var groupNums = group.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
                rotatedList.AddRange(groupNums);
            }

            Console.WriteLine(String.Join(" ", rotatedList));
        }
    }
}
