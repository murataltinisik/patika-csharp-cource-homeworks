// Get Value
Console.Write("Onaylıyor musunuz? (true/false): ");
bool isConfirm = bool.TryParse(Console.ReadLine(), out bool result);

if (isConfirm) {
    Console.WriteLine($"Sonuç: {result}");
}
else
{
    Console.WriteLine("Girilen değer True-False olmalıdır!");
}