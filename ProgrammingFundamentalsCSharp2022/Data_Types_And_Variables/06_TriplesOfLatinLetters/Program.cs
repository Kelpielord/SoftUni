using System;

namespace _06_TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int p = 0; p < n; p++)
                    {
                        char one = (char) (i + 'a');
                        char two = (char) (j + 'a');
                        char three = (char) (p + 'a');
                        Console.WriteLine($"{one}{two}{three}");
                    }
                }
            }
        }
    }
}
