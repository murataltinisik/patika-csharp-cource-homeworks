namespace _04Project;

public class Author
{
    public int Id {get; set;}
    public string Name { get; set; }

    public Author(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return $"Author ID: {Id}\n" +
               $"Author Name: {Name}\n";
    }
}