using OOP;

namespace _06Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Geometric Shapes
            Square square = new Square(5);
            Triangle triangle = new Triangle(3, 4);
            Rectangle rectangle = new Rectangle(4, 6);

            // Print the calculated areas
            Console.WriteLine("Kare Alanı: " + square.CalculateArea());
            Console.WriteLine("Dik Üçgen Alanı: " + triangle.CalculateArea());
            Console.WriteLine("Dikdörtgen Alanı: " + rectangle.CalculateArea());
        }
    }
}