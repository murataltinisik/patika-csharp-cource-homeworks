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