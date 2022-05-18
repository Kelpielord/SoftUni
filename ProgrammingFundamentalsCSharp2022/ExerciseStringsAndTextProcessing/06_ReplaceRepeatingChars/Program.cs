using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToList();
            string result = string.Empty;

            for (int i = 0; i < words.Count - 1; i++)
            {
                char currentStr = words[i];
                char lastStr = words[i + 1];
                if (currentStr == lastStr)
                {
                    words.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join("", words));
        }
    }
}
