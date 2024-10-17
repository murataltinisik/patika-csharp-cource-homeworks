# Pratik - Encapsulation (Car APP)

## Class Structure

### `Car` Class

The `Car` class has the following properties and methods:

- **Properties**:
  - `string Brand`: The brand of the car.
  - `string Model`: The model of the car.
  - `string Color`: The color of the car.
  - `int NumberOfDoors`: The number of doors the car has, with validation to ensure it is either 2 or 4.

- **Constructors**:
  - `Car(string brand, string model, string color)`: Initializes a new `Car` object with brand, model, and color.
  - `Car(string brand, string model, string color, int numberOfDoors)`: Initializes a new `Car` object with brand, model, color, and number of doors. The number of doors is validated to be either 2 or 4; if not, it is set to -1 and an error message is displayed.

- **Methods**:
  - `void GetCarDetail(Car car)`: Displays the details of the car, including brand, model, color, and number of doors (if valid).

## Code Example

Here's how you can create a `Car` object and display its details:

```csharp
using OOP;

// Create a car object with 4 doors
Car car1 = new Car("Toyota", "Corolla", "White", 4);
car1.GetCarDetail(car1);

// Create a car object with an invalid number of doors
Car car2 = new Car("BMW", "X5", "Black", 5);
car2.GetCarDetail(car2);

// Create a car object without specifying the number of doors
Car car3 = new Car("Honda", "Civic", "Blue");
car3.GetCarDetail(car3);
