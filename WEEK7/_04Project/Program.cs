using _04Project;


// Define tables -> author, book
List<Author> authors = new List<Author>()
{
    new Author(1, "Orhan Pamuk"),
    new Author(2, "Elif Şafak"),
    new Author(3, "Ahmet Ümit"),
};

List<Book> books = new List<Book>()
{
    new Book(1, 1, "Kar"),
    new Book(2, 1, "İstanbul"),
    new Book(3, 2, "10 Minutes 38 Seconds in This Strange World"),
    new Book(4, 3, "Beyoğlu Rapsodisi"),
};

// --------------------------- QUERY 1
var dataSource = books.Join(
    authors,
    book => book.AuthorId,
    author => author.Id,
    (book, author) => new
    {
        BookTitle = book.Title,
        AuthorName = author.Name,
    }
);

// --------------------------- QUERY 2
var dataSource2 = from book in books
    join author in authors on book.AuthorId equals author.Id
    select new
    {
        BookTitle = book.Title,
        AuthorName = author.Name,
    };


foreach (var data in dataSource)
    Console.WriteLine($"Book Title: {data.BookTitle}\n" +
                      $"Author Name: {data.AuthorName}\n" +
                      $"------------");

Console.WriteLine();

foreach (var data in dataSource2)
    Console.WriteLine($"Book Title: {data.BookTitle}\n" +
                      $"Author Name: {data.AuthorName}\n" +
                      $"------------");
