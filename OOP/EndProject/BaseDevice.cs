namespace OOP
{
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
            Console.WriteLine($"Telefon Adı -> {base.Name}");
            Console.WriteLine($"Ürün Açıklama -> {base.Description}");
            Console.WriteLine($"Seri Numarası -> {base.SerialNumber}");
            Console.WriteLine($"İşletim Sistemi -> {base.OperatingSystem}");
            Console.WriteLine($"Üretim Tarihi -> {base.ProductionDate}");
            Console.WriteLine("Lisans Bilgisi Var mı? -> {0}", IsLicence ? "EVET" : "HAYIR");
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
            Console.WriteLine($"Bilgisayar Adı -> {base.Name}");
            Console.WriteLine($"Ürün Açıklama -> {base.Description}");
            Console.WriteLine($"Seri Numarası -> {base.SerialNumber}");
            Console.WriteLine($"İşletim Sistemi -> {base.OperatingSystem}");
            Console.WriteLine($"Üretim Tarihi -> {base.ProductionDate}");
            Console.WriteLine($"USB Port Sayısı -> {_usbNumber}");
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
                    Console.WriteLine("USB 2 veya 4 Adet olabilir!");
                }
            }
        }
    }
}