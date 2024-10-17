# Pratik - Abstraction

## Classes

### 1. Employee (Abstract Class)

The `Employee` class is an abstract base class that defines common properties and behaviors for all employees in the company. 

- **Properties**:
  - `Name`: The first name of the employee.
  - `Surname`: The last name of the employee.
  - `Department`: The department in which the employee works.

- **Constructor**:
  - The constructor takes `name`, `surname`, and `department` as parameters to initialize the employee's basic information.

- **Method**:
  - `GetTask()`: This is an abstract method, which means that it must be implemented by any class that inherits from `Employee`. Each type of employee will provide its own implementation of this method.

### 2. SoftwareDeveloper (Derived Class)

The `SoftwareDeveloper` class inherits from `Employee` and represents employees working as software developers in the company.

- **Constructor**:
  - The constructor calls the base class (`Employee`) constructor to initialize the common properties.

- **Method**:
  - `GetTask()`: This method is overridden to display a message that the employee works as a software developer.

### 3. ProjectManager (Derived Class)

The `ProjectManager` class inherits from `Employee` and represents employees working as project managers in the company.

- **Constructor**:
  - The constructor calls the base class (`Employee`) constructor to initialize the common properties.

- **Method**:
  - `GetTask()`: This method is overridden to display a message that the employee works as a project manager.

### 4. SalesRepresentative (Derived Class)

The `SalesRepresentative` class inherits from `Employee` and represents employees working as sales representatives in the company.

- **Constructor**:
  - The constructor calls the base class (`Employee`) constructor to initialize the common properties.

- **Method**:
  - `GetTask()`: This method is overridden to display a message that the employee works as a sales representative.

## Example Usage

Here is an example of how you can use this system to create employees and display their tasks:

```csharp
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define Employees
            Employee softwareDeveloper = new SoftwareDeveloper("Murat", "Altınışık", "IT");
            Employee projectManager = new ProjectManager("Hasan", "Çıldırmış", "Management");
            Employee salesRepresentative = new SalesRepresentative("Grals", "Reis", "Sales");

            // Print Get Task
            softwareDeveloper.GetTask();
            projectManager.GetTask();
            salesRepresentative.GetTask();
        }
    }
}
