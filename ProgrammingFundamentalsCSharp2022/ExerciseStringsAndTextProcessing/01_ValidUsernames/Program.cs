using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01_ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            Regex regex1 = new Regex(@"^[a-zA-Z0-9_-]+$");

            foreach (var username in usernames)
            {
                checkIfUsernameValid(regex1, username);
            }
        }
        private static void checkIfUsernameValid(Regex regex1, string username)
        {
            if (username.Length >= 3 && username.Length <= 16)
            {
                if (regex1.IsMatch(username))
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
