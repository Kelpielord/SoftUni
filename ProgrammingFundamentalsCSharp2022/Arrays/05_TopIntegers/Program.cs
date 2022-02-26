using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrOfNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> biggestNums = new List<int>();
            
            for (int i = 0; i < arrOfNums.Length; i++)
            {
                bool onlySmallerNumbersOnRightSide = true;
                for (int j = i + 1; j < arrOfNums.Length; j++)
                {
                    if (arrOfNums[i] <= arrOfNums[j])
                    {
                        onlySmallerNumbersOnRightSide = false;
                        break;
                    }
                }

                if (onlySmallerNumbersOnRightSide == true)
                {
                    biggestNums.Add(arrOfNums[i]);
                }
            }
            Console.WriteLine(String.Join(" ", biggestNums));
        }
    }
}
