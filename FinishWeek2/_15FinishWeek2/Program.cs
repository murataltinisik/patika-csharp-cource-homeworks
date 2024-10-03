// RoadCalculation
double RoadCalculation(int speed, double time)
{
    return speed * time;
}

#region GET VALUES
Console.Write("Hız Bilgisini Giriniz: ");
bool isNumericSpeedValue = int.TryParse(Console.ReadLine(), out int speed);

Console.Write("Zaman bilgisini giriniz (SAAT): ");
bool isNumericTimeValue = double.TryParse(Console.ReadLine(), out double time);
#endregion

#region CONTROL and FINISH
if (isNumericSpeedValue && isNumericTimeValue)
{
    double result = RoadCalculation(speed, time);
    Console.WriteLine($"Gidelen Yol: {result} KM");
}
else
{
    Console.WriteLine("Girilen değerler hatalı!!!");
}
#endregion