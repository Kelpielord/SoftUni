using System;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string chars = Console.ReadLine();

            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }
        }
    }
}