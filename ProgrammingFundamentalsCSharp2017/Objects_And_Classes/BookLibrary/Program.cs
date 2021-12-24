
int n = int.Parse(Console.ReadLine());
Library library = new Library("Something");
for (int i = 0; i < n; i++)
{
    string[] inputTokens = Console.ReadLine().Split().ToArray();
    var book = new Book(inputTokens[0], inputTokens[1], inputTokens[2], inputTokens[3], inputTokens[4], double.Parse(inputTokens[5]));
    library.Books.Add(book);
}

var groups = library.Books.GroupBy(x => x.Author);

foreach (var group in groups.OrderByDescending(x => x.Sum(b => b.Price)))
{
    double sumPrice = group.Sum(b => b.Price);
    Console.WriteLine($"{group.Key} -> {sumPrice}");
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public string ReleaseDate { get; set; }
    public string ISBN { get; set; }
    public double Price { get; set; }

    public Book(string title, string author, string publisher, string releaseDate, string isbn, double price)
    {
        this.Title = title;
        this.Author = author;
        this.Publisher = publisher;
        this.ReleaseDate = releaseDate;
        this.ISBN = isbn;
        this.Price = price;
    }
}

public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }

    public Library(string name)
    {
        Books = new List<Book>();
        this.Name = name;
    }
}