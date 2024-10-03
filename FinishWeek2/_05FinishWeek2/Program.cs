// Get Value
Console.Write("Yaşınızı Giriniz: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int age);

if (isNumber) {
    // Result
    string result = age >= 18 ? "+" : "-";

    // Write
    Console.WriteLine(result);
} else {
    Console.WriteLine("Geçersiz veri girişi!");
}