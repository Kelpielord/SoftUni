using System;
using System.Linq;

namespace _02_VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetVowels());
        }

        static int GetVowels()
        {
            int count = 0;
            string Sentence = Console.ReadLine().ToLower();
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < Sentence.Length; i++)
            {
                if (vowels.Contains(Sentence[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
