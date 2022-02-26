using System;

namespace _01_SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetSmallestNum(num1, num2, num3));
        }

        static int GetSmallestNum(int number1, int number2, int number3)
        {
            int smallestNum = Math.Min(number1, number2);
            if (smallestNum > number3)
            {
                return number3;
            }

            return smallestNum;
        }
    }
}
