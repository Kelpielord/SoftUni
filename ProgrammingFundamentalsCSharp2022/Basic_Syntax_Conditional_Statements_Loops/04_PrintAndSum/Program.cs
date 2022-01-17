using System;

namespace _04_PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startSequence = int.Parse(Console.ReadLine());
            int endSequence = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = startSequence; i <= endSequence; i++)
            {
                sum += i;
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
