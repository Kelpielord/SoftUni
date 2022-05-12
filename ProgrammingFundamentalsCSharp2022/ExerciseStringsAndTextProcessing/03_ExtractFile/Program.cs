using System;

namespace _03_ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textToCipher = Console.ReadLine();
            string cipherResult = string.Empty;

            for (int i = 0; i < textToCipher.Length; i++)
            {
                char letter = textToCipher[i];
                letter += (char)3;
                cipherResult += letter;
            }

            Console.WriteLine(cipherResult);
        }
    }
}
