using System;

namespace _06_MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string middleCharacters = GetMiddleCharacter(sentence);
            Console.WriteLine(middleCharacters);
        }

        static string GetMiddleCharacter(string sentence)
        {
            int middIndex = sentence.Length / 2;

            if (sentence.Length % 2 == 0)
            {
                return $"{sentence[middIndex - 1]}{sentence[middIndex]}";
            }
            return $"{sentence[middIndex]}";
        }
    }
}
