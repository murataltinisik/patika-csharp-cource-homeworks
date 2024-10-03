// Sum Method
int sum(int s1, int s2)
{
    return s1 + s2;
}

// Get Values
Console.Write("Birinci Sayıyı Giriniz: ");
bool firstValueIsNumber = int.TryParse(Console.ReadLine(), out int s1);

Console.Write("İkinci Sayıyı Giriniz: ");
bool secondValueIsNumber = int.TryParse(Console.ReadLine(), out int s2);

if (!firstValueIsNumber || !secondValueIsNumber)
{
    Console.WriteLine("Girilen Değerler Geçersiz formatta!!");
    Environment.Exit(0); // Stack Overflow'dan araştırdım.
}

// Calculate
int total = sum(s1, s2);

// Finish
Console.WriteLine(); 
Console.WriteLine($"Toplam: {total}");