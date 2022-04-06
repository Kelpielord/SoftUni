using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02_MessageTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"^!([A-Z][A-Za-z]{2,})!:\[([A-Z][A-Za-z]{7,})\]$");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var match = regex.Match(input);
                if (!match.Success)
                {
                    Console.WriteLine("The message is invalid");
                    continue;
                }
                string command = match.Groups[1].Value;
                string message = match.Groups[2].Value;
                string[] asciiNumbers = message.Select(c => "" + (int) c).ToArray();
                Console.WriteLine($"{command}: {string.Join(" ", asciiNumbers)}");
            }
        }
    }
}
