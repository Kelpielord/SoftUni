using System;
using System.Linq;

namespace _02_CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] charsToMultiply = Console.ReadLine().Split(' ');
            //string str1 = charsToMultiply[0];
            //string str2 = charsToMultiply[1];

            string[] token = Console.ReadLine().Split();
            string firstStr = token[0];
            string secondStr = token[1];

            int minLenght = 0;
            int maxLenght = 0;
            int sumOfTwoStrings = 0;
            string maxStrLenght = null;

            if (firstStr.Length > secondStr.Length)
            {
                maxLenght = firstStr.Length;
                minLenght = secondStr.Length;
                maxStrLenght = firstStr;
            }
            else if (secondStr.Length > firstStr.Length)
            {
                maxLenght = secondStr.Length;
                minLenght = firstStr.Length;
                maxStrLenght = secondStr;
            }
            else if (firstStr.Length == secondStr.Length)
            {
                minLenght = firstStr.Length;
            }

            for (int i = 0; i < minLenght; i++)
            {
                sumOfTwoStrings += firstStr[i] * secondStr[i];
            }

            int remainder = maxLenght - minLenght;
            int loop = maxLenght - remainder;
            string Sum;

            if (firstStr.Length < secondStr.Length)
            {
                Sum = secondStr.Substring(loop);
                for (int i = 0; i < Sum.Length; i++)
                {
                    sumOfTwoStrings += Sum[i];
                }
            }
            else if (secondStr.Length < firstStr.Length)
            {
                Sum = firstStr.Substring(loop);
                for (int i = 0; i < Sum.Length; i++)
                {
                    sumOfTwoStrings += Sum[i];
                }
            }

            Console.WriteLine(sumOfTwoStrings);
        }
    }
}
