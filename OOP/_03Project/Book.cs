namespace OOP
{
    class Book
    {
        // Class Properties
        private int pageSize;
        private string bookName;
        private string publisher;
        private string authorName;
        private string authorSurname;
        private DateTime createdAt;

        // Empty Constructor
        public Book() { }

        // Constructor with Parameters
        public Book(int pageSize, string bookName, string publisher, string authorName, string authorSurname)
        {
            PageSize = pageSize;
            BookName = bookName;
            Publisher = publisher;
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            CreatedAt = DateTime.Now;
        }

        // Getters and Setters
        public int PageSize { get; set; }
        public string BookName { get; set; }
        public string Publisher { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public DateTime CreatedAt { get; set; }


        // Get Book Detail
        public void GetBookDetail(Book book)
        {
            Console.WriteLine($"{book.AuthorName} {book.AuthorSurname} adlı yazarın, {book.PageSize} sayfalık kitabı. {book.Publisher} yayınevinden çıkan, {book.BookName} adlı kitabı {book.CreatedAt} tarihinde oluşturuldu.");
            Console.WriteLine();
        }
    }
}