# 💣 Hafta 5 - Kapanış

#### Bir araba fabrikasonda araba üretiyoruz.

*Araba -> Üretim Tarihi, Seri Numarası, Marka, Model, Renk, Kapı Sayısı*

Yukarıdaki propertylere sahip bir Araba classı tanımlayalım.

## - Program akışı -
1. Konsol ekranından kullanıcıya araba üretmek isteyip istemediğini soralım. Üretmek istiyorsa e, istemiyorsa h harfi ile yanıt versin. Büyük - Küçük harf duyarlılığını ortadan kaldıralım. Geçersiz bir cevap verirse, bu cevabın geçersiz olduğunu söyleyerek aynı soruyu tekrar yöneltelim.
2. Kullanıcının cevabı hayır programı sonlandıralım, evet ise bir araba nesnesi üretip özelliklerini konsol ekranından kullanıcıya girdirelim.
3. Üretim Tarihi değeri araba üretilirken otomatik olarak o an olarak atanacak.
4. Kapı Sayısı için sayısal olmayan bir değer atanılmaya çalışılırsa programın exception fırlatmasını engelleyelim, uyarı mesajı verelim ve kullanıcıyı yeniden o satıra yönlendirelim. (goto komutunu araştırınız.)
5. Oluşturulan araba nesnesini arabalar isimli bir listeye atayınız.
6. Kullanıcıya başka araba oluşturmak isteyip istemediğini sorunuz, evet ise program akışında 2. aşamaya geri dönünüz ve yeni bir araba üretip listeye ekleyiniz. Cevap hayır ise arabalar listesinin bütün elemanlarının Seri numaralarını ve markalarını yazdırınız

## Car Class
```csharp
namespace EndProject;

public class Car
{
    private string Color { get; set; }
    private string Model { get; set; }
    private string SerialNumber { get; set; }
    private int NumberOfDoors { get; set; }
    private DateTime ProductionDate { get; set; }

    public Car(string color, string model, string serialNumber, int numberOfDoors)
    {
        Color = color;
        Model = model;
        SerialNumber = serialNumber;
        NumberOfDoors = numberOfDoors;
        ProductionDate = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Color: {Color} \n" +
               $"Model: {Model} \n" +
               $"Serial Number: {SerialNumber} \n" +
               $"Number Of Doors: {NumberOfDoors} \n" +
               $"Production Date: {ProductionDate}";
    }
}
```

## Usage
```csharp
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
```