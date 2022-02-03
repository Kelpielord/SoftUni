using System;
using System.Collections.Generic;

namespace _02_CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');
            List<string> sameWords = new List<string>();
            foreach (string word in arr2)
            {
                int wordsPos = Array.IndexOf(arr1, word);
                if (wordsPos > -1)
                {
                    sameWords.Add(word);
                }
            }
            Console.WriteLine(string.Join(" ", sameWords));
        }
    }
}
