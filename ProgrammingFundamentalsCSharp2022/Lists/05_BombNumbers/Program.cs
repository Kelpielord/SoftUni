using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = bombAndPower[0];
            int bombPower = bombAndPower[1];

            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] != bombNumber)
                {
                    continue;
                }
                int numbersAfterBomb = integers.Count - i - 1;
                if (numbersAfterBomb < bombPower)
                {
                    integers.RemoveRange(i, numbersAfterBomb + 1);
                }
                else
                {
                    integers.RemoveRange(i, bombPower + 1);
                }
                if (bombPower > i)
                {
                    integers.RemoveRange(0, i);
                }
                else
                {
                    integers.RemoveRange(i - bombPower, bombPower);
                }
                i = 0;
            }
            //Console.WriteLine(string.Join(" ", integers));
            Console.WriteLine(integers.Sum());
        }
    }
}
