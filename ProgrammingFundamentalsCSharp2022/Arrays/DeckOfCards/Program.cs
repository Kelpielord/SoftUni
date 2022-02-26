using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(new string[] { ", ", "," }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToList();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] {", ", ","}, StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];

                if (command == "Add")
                {
                    string card = input[1];
                    if (cards.Contains(card))
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                    else
                    {
                        cards.Add(card);
                        Console.WriteLine("Card successfully added");
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(input[1]);
                    if (index < 0 || index > cards.Count)
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }
                    string card = input[2];
                    if (cards.Contains(card))
                    {
                        Console.WriteLine("Card is already added");
                    }
                    else
                    {
                        cards.Insert(index, card);
                        Console.WriteLine("Card successfully added");
                    }
                }
                else if (command == "Remove")
                {
                    string card = input[1];
                    if (cards.Contains(card))
                    {
                        cards.Remove(card);
                        Console.WriteLine("Card successfully removed");

                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if (command == "Remove At")
                {
                    int index = int.Parse(input[1]);
                    if (index < 0 || index > cards.Count)
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }
                    else
                    {
                        cards.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }
                }
            }
            Console.WriteLine(String.Join(", ", cards));
        }
    }
}
