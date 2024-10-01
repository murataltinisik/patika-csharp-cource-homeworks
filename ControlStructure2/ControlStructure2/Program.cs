// Start
Console.WriteLine("---- RÜYA Manavına Hoşgeldiniz ----");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer Meyveler = 4 TL");

// Get Input Value
Console.Write("Hangi meyveyi almak istersiniz? (Elma/Armut/Cılek/Muz/Dıger): ");
string input = Console.ReadLine().ToUpper();

// Value is Fruit Enum
bool isFruitValue = Enum.TryParse(input, true, out Fruits result);

// Check Values
Console.WriteLine();
Console.WriteLine("-------------------------------------");
Console.Write($"Seçilen {result}: ");
switch (result) {
    case Fruits.ELMA:
        Console.WriteLine("Meyvenin fiyatı = 2 TL");
    break;
    case Fruits.ARMUT:
        Console.WriteLine("Meyvenin fiyatı = 3 TL");
    break;
    case Fruits.CILEK:
        Console.WriteLine("Meyvenin fiyatı = 2 TL");
    break;
    case Fruits.MUZ:
        Console.WriteLine("Meyvenin fiyatı = 3 TL");
    break;
    case Fruits.DIGER:
        Console.WriteLine("Meyvenin fiyatı = 4 TL");
    break;
    default:
        Console.WriteLine("Meyvenin fiyatı = 4 TL");
    break;
}
Console.WriteLine("-------------------------------------");

// Fruits
enum Fruits
{
    ELMA,
    ARMUT,
    CILEK,
    MUZ,
    DIGER
}
