using System;

namespace _07_NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintMatrix(num);
        }
        
        static void PrintMatrix(int num)
        {
            for (int i = 0; i < num; i++)
            {
                PrintRow(num);
            }
        }

        static void PrintRow(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
