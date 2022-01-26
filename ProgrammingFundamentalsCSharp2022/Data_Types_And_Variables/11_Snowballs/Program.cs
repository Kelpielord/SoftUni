using System;
using System.Numerics;

namespace _11_Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfSnowballs = int.Parse(Console.ReadLine());
            BigInteger highestSnowballSnow = 0;
            BigInteger highestSnowballTime = 0;
            BigInteger highestSnowballQuality = 0;
            BigInteger highestSnowballValue = 0;

            for (int i = 0; i < numOfSnowballs; i++)
            {
                BigInteger snowballSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballTime = BigInteger.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger currentSnowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (currentSnowballValue > highestSnowballValue)
                {
                    highestSnowballValue = currentSnowballValue;
                    highestSnowballSnow = snowballSnow;
                    highestSnowballTime = snowballTime;
                    highestSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{highestSnowballSnow} : {highestSnowballTime} = {highestSnowballValue} ({highestSnowballQuality})");
        }
    }
}
