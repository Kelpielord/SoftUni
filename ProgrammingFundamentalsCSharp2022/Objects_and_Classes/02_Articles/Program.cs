using System;
using System.Linq;

namespace _02_Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleContent = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string title = articleContent[0];
            string content = articleContent[1];
            string author = articleContent[2];

            Article article = new Article(title, content, author);

            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = input[0];
                string commandValue = input[1];
                CheckCommand(article, command, commandValue);
            }
            Console.WriteLine(article.ToString());
        }

        private static void CheckCommand(Article article, string command, string commandValue)
        {
            if (command == "Edit")
            {
                article.Edit(commandValue);
            }
            else if (command == "ChangeAuthor")
            {
                article.ChangeAuthor(commandValue);

            }
            else if (command == "Rename")
            {
                article.Rename(commandValue);
            }
        }
    }
}
