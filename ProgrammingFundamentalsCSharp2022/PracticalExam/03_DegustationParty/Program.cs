using System;
using System.Collections.Generic;

namespace _03_DegustationParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> clients = new Dictionary<string, HashSet<string>>();
            int dislikeCounter = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                string[] tokens = input.Split('-');
                string clientLikeOrDislike = tokens[0];
                string clientName = tokens[1];
                string clientMeal = tokens[2];

                if (clientLikeOrDislike == "Like")
                {
                    if (!clients.ContainsKey(clientName))
                    {
                        clients.Add(clientName, new HashSet<string>());
                    }
                    clients[clientName].Add(clientMeal);
                }
                else if (clientLikeOrDislike == "Dislike")
                {
                    if (!clients.ContainsKey(clientName))
                    {
                        Console.WriteLine($"{clientName} is not at the party.");
                        continue;
                    }
                    bool removedMeal = clients[clientName].Remove(clientMeal);
                    if (!removedMeal)
                    {
                        Console.WriteLine($"{clientName} doesn't have the {clientMeal} in his/her collection.");
                    }
                    else
                    {
                        dislikeCounter++;
                        Console.WriteLine($"{clientName} doesn't like the {clientMeal}.");
                    }
                }
            }

            foreach (var client in clients)
            {
                Console.WriteLine($"{client.Key}: {string.Join(", ", client.Value)}");
            }
            Console.WriteLine($"Unliked meals: {dislikeCounter}");
        }
    }
}
