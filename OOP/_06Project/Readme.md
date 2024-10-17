# Pratik - Polymorphism

## Classes

### 1. BaseGeometric Class

The `BaseGeometric` class is the base class that defines the common properties and methods for geometric shapes.

- **Properties**:
  - `Width`: The width of the shape.
  - `Height`: The height of the shape.

- **Methods**:
  - `CalculateArea()`: A virtual method that calculates the area of the shape by default as `Width * Height`. This method can be overridden in derived classes for specific shapes.

### 2. Square Class

The `Square` class is derived from `BaseGeometric`. Since all sides of a square are equal, the `Square` class uses a single parameter for both the width and height.

- **Constructor**:
  - Takes a single parameter `border` which represents the length of a side of the square. Both `Width` and `Height` are set to this value.

### 3. Rectangle Class

The `Rectangle` class is derived from `BaseGeometric` and represents a rectangle with different width and height values.

- **Constructor**:
  - Takes two parameters, `width` and `height`, and passes them to the `BaseGeometric` class.

### 4. Triangle Class

The `Triangle` class is derived from `BaseGeometric` and represents a right triangle. Its area is calculated differently than the square and rectangle.

- **Constructor**:
  - Takes two parameters, `width` and `height`, and passes them to the `BaseGeometric` class.

- **Methods**:
  - `CalculateArea()`: Overrides the base class method to calculate the area of a triangle using the formula `(Width * Height) / 2`.

## Usage

Here is an example of how you can use this application to create shapes and calculate their areas:

```csharp
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
