using System;

namespace _05_AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int numToSubtract = int.Parse(Console.ReadLine());
            Console.WriteLine(AddAndSubtractNums(num1, num2, numToSubtract));
        }

        static int AddAndSubtractNums(int num1, int num2, int numToSubtract)
        {
            int sumOfNums = num1 + num2;
            int finalResult = sumOfNums - numToSubtract;
            return finalResult;
        }
    }
}
