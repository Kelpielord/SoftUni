using System;

namespace _03_CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            CharactersInRange(char1, char2);
        }

        static void CharactersInRange(char char1, char char2)
        {
            char start = char1 > char2 ? char2 : char1;
            char end = char1 > char2 ? char1 : char2;

            for (char i = ++start; i < end; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
