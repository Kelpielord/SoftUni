using System;

namespace _02_SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string parseNum = num.ToString();
            double result = 0;
            foreach (var n in parseNum)
            {
                result += char.GetNumericValue(n);
            }
            Console.WriteLine(result);
        }
    }
}
