using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int maxSequence = 0;
            int maxNum = 0;
            int currentSequence = 0;
            int currentNum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (currentNum == arr[i])
                {
                    currentSequence++;
                }
                else
                {
                    currentNum = arr[i];
                    currentSequence = 1;
                }

                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    maxNum = currentNum;
                }
            }
            string sequence = string.Concat(Enumerable.Repeat(maxNum + " ", maxSequence));
            Console.WriteLine(sequence);
        }
    }
}
