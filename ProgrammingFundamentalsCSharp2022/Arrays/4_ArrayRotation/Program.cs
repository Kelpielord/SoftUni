using System;
using System.Linq;

namespace _04_ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lastArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotationNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotationNum; i++)
            {
                int[] currentArr = new int[lastArr.Length];
                for (int j = 1; j < lastArr.Length; j++)
                {
                    currentArr[j-1] = lastArr[j];
                }
                currentArr[currentArr.Length - 1] = lastArr[0];
                lastArr = currentArr;
            }
            Console.WriteLine(String.Join(" ", lastArr));
        }
    }
}
