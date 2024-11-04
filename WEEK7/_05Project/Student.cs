namespace _05Project;

public class Student
{
    public int Id {get; set;}
    public string Name {get; set;}
    public int ClassRoomId {get; set;}

    public Student(int id, int classRoomId, string name)
    {
        Id = id;
        Name = name;
        ClassRoomId = classRoomId;
    }
    
    public override string ToString()
    {
        return $"\tStudent Id: {Id}\n" +
               $"\tStudent Name: {Name}\n" +
               $"\tClass Room Id: {ClassRoomId}\n";
    }
}