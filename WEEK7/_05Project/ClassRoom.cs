namespace _05Project;

public class ClassRoom
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ClassRoom(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return $"Class Id: {Id}\n" +
               $"Class Name: {Name}\n";
    }
}