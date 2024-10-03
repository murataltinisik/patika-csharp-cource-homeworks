// NumberIsEvenOrOdd
bool NumberIsEvenOrOdd(int value)
{
    return value % 2 == 0 ? true : false;
}

// Get Values
Console.Write("Bir Sayı Giriniz: ");
bool isNumber = int.TryParse(Console.ReadLine(), out var number);

// Check
if (isNumber)
{
    // Result
    bool result = NumberIsEvenOrOdd(number);

    // Finish
    Console.WriteLine($"Çift/Tek: {result}");
}
else
{
    Console.WriteLine("Girilen değer yanlış formatta girilmiş!");
}