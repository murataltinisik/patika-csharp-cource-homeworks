// Get Values
Console.Write("1. Yaş bilgisini Giriniz: ");
bool age1IsNumber = int.TryParse(Console.ReadLine(), out int age1);

Console.Write("2. Yaş bilgisini Giriniz: ");
bool age2IsNumber = int.TryParse(Console.ReadLine(), out int age2);

Console.Write("3. Yaş bilgisini Giriniz: ");
bool age3IsNumber = int.TryParse(Console.ReadLine(), out int age3);

// Check are ages number
if (age1IsNumber && age2IsNumber && age3IsNumber)
{
    // Put array to values
    int[] ages = { age1, age2, age3 };

    // Write Max Value
    Console.WriteLine();
    Console.WriteLine("----------- BİLGİLER -----------");
    Console.WriteLine($"En Büyük Yaş: {ages.Max()}");
    Console.WriteLine("--------------------------------");
    Console.WriteLine();
}
else
{
    Console.WriteLine("Girilen değerlerden herhangi biri hatalı formatta girilmiş!!");
}