using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01_Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string spellToDecipher = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Abracadabra")
                {
                    break;
                }
                string[] tokens = input.Split();

                if (tokens[0] == "Abjuration")
                {
                    spellToDecipher = spellToDecipher.ToUpper();
                    Console.WriteLine(spellToDecipher);
                }
                else if (tokens[0] == "Necromancy")
                {
                    spellToDecipher = spellToDecipher.ToLower();
                    Console.WriteLine(spellToDecipher);
                }
                else if (tokens[0] == "Illusion")
                {
                    StringBuilder charToReplace = new StringBuilder(spellToDecipher);
                    int index = int.Parse(tokens[1]);
                    if (index > spellToDecipher.Length - 1 || index < 0)
                    {
                        Console.WriteLine("The spell was too weak.");
                        continue;
                    }
                    char letter = char.Parse(tokens[2]);
                    charToReplace[index] = letter;
                    spellToDecipher = charToReplace.ToString();
                    Console.WriteLine("Done!");
                }
                else if (tokens[0] == "Divination")
                {
                    string firstSubstring = tokens[1];
                    string secondSubstring = tokens[2];
                    int index = spellToDecipher.IndexOf(firstSubstring);
                    if (index < 0)
                    {
                        continue;
                    }
                    spellToDecipher = spellToDecipher.Replace(firstSubstring, secondSubstring);
                    Console.WriteLine(spellToDecipher);
                }
                else if (tokens[0] == "Alteration")
                {
                    string substring = tokens[1];
                    int index = spellToDecipher.IndexOf(substring);
                    if (index < 0)
                    {
                        continue;
                    }
                    string newSpell = spellToDecipher.Remove(index, substring.Length);
                    spellToDecipher = newSpell;
                    Console.WriteLine(spellToDecipher);
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
            }
        }
    }
}
