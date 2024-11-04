namespace _04Project;

public class Book
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public string Title { get; set; }

    public Book(int id, int authorId, string title)
    {
        Id = id;
        AuthorId = authorId;
        Title = title;
    }
    
    public override string ToString()
    {
        return $"Book ID: {Id}\n" +
               $"Author ID: {AuthorId}\n" +
               $"Book Title: {Title}\n";
    }
}