using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> chars = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (c == ' ')
                {
                    continue;
                }
                if (chars.ContainsKey(c))
                {
                    chars[c] += 1;
                }
                else
                {
                    chars.Add(c, 1);
                }
            }
            foreach (var item in chars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
