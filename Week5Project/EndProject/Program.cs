using EndProject;

// Define List Property
List<Car> cars = new List<Car>();

do
{
    // Get Value -> input
    Console.Write("Do you want to make car? (y/n): ");
    string input  = Console.ReadLine().ToLower();
    
    // If press to "n", exit program
    if (input == "n") break;
    
    // Is not input equals "y" or "n"
    if (input != "y" && input != "n")
    {
        Console.WriteLine("Invalid input");
        continue;
    }

    // Get Values -> Car Object
    Console.Write("Enter Car Color: ");
    string color = Console.ReadLine();
    
    Console.Write("Enter Car Model: ");
    string model = Console.ReadLine();

    Console.Write("Enter Car Serial Number: ");
    string serialNumber = Console.ReadLine();

    Console.Write("Enter Car Number Of Doors: ");
    int numberOfDoors;

    TryAgain:
    try
    {
        numberOfDoors = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Geçersiz Değer Girişi");
        Console.Write("Enter Car Number Of Doors: ");
        goto TryAgain;
    }        
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.Write("Enter Car Number Of Doors: ");
        goto TryAgain;
    }
    
    // Create Car Object
    Car car = new Car(color, model, serialNumber, numberOfDoors);
    
    // Add to car -> list
    cars.Add(car);
} while(true);

// Car List
Console.WriteLine();
Console.WriteLine("--------- CREATED CARS ---------");
foreach (Car car in cars) Console.WriteLine(car);