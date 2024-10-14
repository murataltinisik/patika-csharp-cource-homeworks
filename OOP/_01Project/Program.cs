using OOP;

class Program
{
    static void Main(string[] args)
    {
        // Teacher
        Person teacher = new Person();
        Person student1 = new Person();
        Person student2 = new Person();

        // Set teacher values
        teacher.Name = "Ali";
        teacher.Surname = "Veli";
        teacher.Birthday = "01-01-2000";

        // Set student1 values
        student1.Name = "Murat";
        student1.Surname = "Altınışık";
        student1.Birthday = "12-29-2004";

        // Set student2 values
        student2.Name = "Yusuf";
        student2.Surname = "Altınışık";
        student2.Birthday = "01-01-2010";

        // Write Console
        Console.WriteLine();
        Console.WriteLine($"Öğretmen Bilgileri: {teacher.Name} {teacher.Surname} - {teacher.Birthday}");
        Console.WriteLine($"Öğrenci Bilgileri 1: {student1.Name} {student1.Surname} - {student1.Birthday}");
        Console.WriteLine($"Öğrenci Bilgileri 2: {student2.Name} {student2.Surname} - {student2.Birthday}");
    }
}
