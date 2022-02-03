using System;
using System.Linq;

namespace _03_Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrLenght = int.Parse(Console.ReadLine());
            int[] arr1 = new int[arrLenght];
            int[] arr2 = new int[arrLenght];

            for (int i = 0; i < arrLenght; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    arr1[i] = numbers[0];
                    arr2[i] = numbers[1];
                }
                else
                {
                    arr2[i] = numbers[0];
                    arr1[i] = numbers[1];
                }
                
            }
            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}
