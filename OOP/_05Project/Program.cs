using OOP;

namespace _05Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Teacher Class
            Teacher teacher = new Teacher("Mehmed", "Şemseddin", 100000);
            teacher.Print();

            Console.WriteLine();

            // Create Student Class
            Student student = new Student("Fatih Sultan", "Mehmet", 1453);
            student.Print();
        }
    }
}