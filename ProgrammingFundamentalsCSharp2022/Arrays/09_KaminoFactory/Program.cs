using System;
using System.Linq;
using System.Collections.Generic;


namespace _09_KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] maxArray = null;
            int maxSequence = 0;
            int currentSequence = 0;
            int currentNum = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                int[] arr = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
               
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

                    }
                }

            }
            
            
        }
    }
}
