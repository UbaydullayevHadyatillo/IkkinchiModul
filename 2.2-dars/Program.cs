namespace _2._2_dars;

internal class Program
{
    static List<Book> Books = new List<Book>();
    static void Main(string[] args)
    {
        DataSeed();
        var book = GetMaxPricedBook();
        Console.WriteLine(book.Price);
    }

    static Book GetMaxPricedBook()
    {
        Book book = Books[0];

        foreach(var b in Books)
        {
            if(book.Price<b.Price)
            {
                book = b;
            }
        }
        return book;
    }

    static void DataSeed()
    {
        Books.Add(new Book()
        {
            BookId = Guid.NewGuid(),
            Title = "Jumavoy",
            Author = "Robinzon Kuruzo",
            Price = 10,
            Description = "sarguzasht",
            Created = DateTime.Now,
            Genre = "qzqarli",
            PgeCount = 200,
        });

        Books.Add(new Book()
        {
            BookId = Guid.NewGuid(),
            Title = "sariq devni minib",
            Author = "Xudoyberdi Tohtaboyev",
            Price = 9,
            Description = "Fantastika",
            Created = DateTime.Now,
            Genre = "kamedya",
            PgeCount = 180,
        });

        Books.Add(new Book()
        {
            BookId = Guid.NewGuid(),
            Title = "Harry poter",
            Author = "opa",
            Price = 19,
            Description = "Fantastika",
            Created = DateTime.Now,
            Genre = "Fantastika",
            PgeCount = 380,
        });

    }
}
