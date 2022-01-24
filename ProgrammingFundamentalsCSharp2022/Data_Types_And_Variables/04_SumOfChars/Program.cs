using System;

namespace _04_SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;


            for (int i = 0; i < n; i++)
            {
                char letters = char.Parse(Console.ReadLine());
                int parseLetterToNum = (int)letters;
                result += parseLetterToNum;
            }
            Console.WriteLine($"The sum equals: {result}");
        }
    }
}
