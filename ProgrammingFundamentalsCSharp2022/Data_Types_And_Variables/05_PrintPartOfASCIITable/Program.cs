using System;

namespace _05_PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n; i <= n2; i++)
            {
                char parseN = (char)i;
                Console.Write($"{parseN} ");
            }

        }
    }
}
