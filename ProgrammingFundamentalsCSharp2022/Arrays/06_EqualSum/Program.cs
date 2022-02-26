using System;
using System.Linq;

namespace _06_EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int midnum = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int left = 0; left < i; left++)
                {
                    leftSum += arr[left];
                }
                for (int right = i + 1; right < arr.Length; right++)
                {
                    rightSum += arr[right];
                }
                if (leftSum == rightSum)
                {
                    midnum = i;
                }
            }

            if (midnum > -1)
            {
                Console.WriteLine(midnum);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
