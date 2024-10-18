# 💣 Hafta 4 - Kapanış

### BaseDevice Class

- **Properties:**
  - `Name`: Represents the device name.
  - `Description`: A short description of the device.
  - `SerialNumber`: The serial number of the device.
  - `OperatingSystem`: The device's operating system.
  - `ProductionDate`: The production date of the device, initialized to the current date and time.

- **Constructor:**
  - Initializes the device's name, description, serial number, and operating system.
  - Sets `ProductionDate` to the current date (`DateTime.Now`).

- **Abstract Method:**
  - `PrintInformations()`: Each derived class must implement this method to display the device's information.

```csharp
abstract class BaseDevice
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string SerialNumber { get; set; }
    public string OperatingSystem { get; set; }
    public DateTime ProductionDate { get; set; }

    public BaseDevice(string name, string description, string serialNumber, string operatingSystem)
    {
        Name = name;
        Description = description;
        SerialNumber = serialNumber;
        OperatingSystem = operatingSystem;
        ProductionDate = DateTime.Now;
    }

    public abstract void PrintInformations();
}

class Phone : BaseDevice
{
    private bool IsLicence { get; set; }

    public Phone(string name, string description, string serialNumber, string operatingSystem, bool isLicence) :
            base(name, description, serialNumber, operatingSystem)
    {
        IsLicence = isLicence;
    }

    public override void PrintInformations()
    {
        Console.WriteLine();
        Console.WriteLine($"Phone Name -> {base.Name}");
        Console.WriteLine($"Description -> {base.Description}");
        Console.WriteLine($"Serial Number -> {base.SerialNumber}");
        Console.WriteLine($"Operating System -> {base.OperatingSystem}");
        Console.WriteLine($"Production Date -> {base.ProductionDate}");
        Console.WriteLine("Is Licensed? -> {0}", IsLicence ? "YES" : "NO");
        Console.WriteLine();
    }
}

class Computer : BaseDevice
{
    private int _usbNumber;

    public Computer(string name, string description, string serialNumber, string operatingSystem, int usbNumber) :
          base(name, description, serialNumber, operatingSystem)
    {
        _usbNumber = usbNumber;
    }

    public override void PrintInformations()
    {
        Console.WriteLine();
        Console.WriteLine($"Computer Name -> {base.Name}");
        Console.WriteLine($"Description -> {base.Description}");
        Console.WriteLine($"Serial Number -> {base.SerialNumber}");
        Console.WriteLine($"Operating System -> {base.OperatingSystem}");
        Console.WriteLine($"Production Date -> {base.ProductionDate}");
        Console.WriteLine($"USB Port Number -> {_usbNumber}");
        Console.WriteLine();
    }

    public int UsbNumber
    {
        get
        {
            return _usbNumber;
        }
        set
        {
            if (value == 2 || value == 4)
            {
                _usbNumber = value;
            }
            else
            {
                _usbNumber = -1;
                Console.WriteLine("USB ports can only be 2 or 4!");
            }
        }
    }
}
```