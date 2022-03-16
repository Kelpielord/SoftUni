using System;
using System.Linq;

namespace _03_Articles2_0
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

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int numOfArticles = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfArticles; i++)
            {
                string[] articleContent = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string title = articleContent[0];
                string content = articleContent[1];
                string author = articleContent[2];
                Article article = new Article(title, content, author);
                Console.WriteLine(article.ToString());
            }
            string input = Console.ReadLine();
        }
    }
}
