// Variables
double pi = 3.14;

// CalculateCircleArea
double CalculateCircleArea(int radius)
{
    return pi * Math.Pow(radius, 2);
}

#region GET VALUES
Console.Write("Yarıçap bilgisi giriniz: ");
bool isNumeric = int.TryParse(Console.ReadLine(), out int radius);
#endregion

#region Control and Finish
if (isNumeric)
{
    // Result
    double result = CalculateCircleArea(radius);

    // Write
    Console.WriteLine($"Daire'nin Alanı: {result}");
}
else
{
    Console.WriteLine("Geçersiz bir değer girdiniz!!!");
}
#endregion
