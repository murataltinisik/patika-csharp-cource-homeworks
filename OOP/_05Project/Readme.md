# Pratik - Inheritance

## Classes

### 1. BasePerson Class

The `BasePerson` class is a base class that holds the common properties for both `Teacher` and `Student` classes. It includes:
- **Properties**:
  - `Name` (protected): The first name of the person.
  - `Surname` (protected): The last name of the person.
- **Method**:
  - `Print()`: A virtual method that prints the person's name and surname.

### 2. Teacher Class

The `Teacher` class inherits from `BasePerson`. It adds the following:
- **Properties**:
  - `Salary` (public): The teacher's salary.
- **Constructor**:
  - Initializes `Name`, `Surname`, and `Salary`.
- **Method**:
  - `Print()`: Overrides the `Print()` method to include the teacher's salary in the output.

### 3. Student Class

The `Student` class also inherits from `BasePerson`. It adds the following:
- **Properties**:
  - `Number` (public): The student's number.
- **Constructor**:
  - Initializes `Name`, `Surname`, and `Number`.
- **Method**:
  - `Print()`: Overrides the `Print()` method to include the student's number in the output.

## Example Usage

Here is an example of how you might create and use `Teacher` and `Student` objects:

```csharp
using System;

namespace OOP
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
