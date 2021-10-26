using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;
            
            
            for (int i = 1; i <= number; i++)
            {
                var leftNumber = int.Parse(Console.ReadLine());
                leftSum += leftNumber;
            }

            for (int i = 1; i <= number; i++)
            {
                var rightNumber = int.Parse(Console.ReadLine());
                rightSum += rightNumber;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}