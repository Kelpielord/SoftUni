using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                
                if (i % 2 == 0)
                {
                    oddSum += num;
                }
                else
                {
                    evenSum += num;
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}