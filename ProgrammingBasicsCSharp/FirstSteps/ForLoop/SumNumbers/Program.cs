using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numCount; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                sum += nums;
            }

            Console.WriteLine(sum);
        }
    }
}