using System;

namespace NumbersN_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            for (int i = nums; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}