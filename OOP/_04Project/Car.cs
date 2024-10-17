namespace OOP
{
    class Car
    {
        private string Brand;
        private string Model;
        private string Color;
        private int numberOfDoors;

        public Car(string brand, string model, string color)
        {
            Brand = brand;
            Model = model;
            Color = color;
        }

        public Car(string brand, string model, string color, int numberOfDoors)
        {
            Brand = brand;
            Model = model;
            Color = color;
            NumberOfDoors = numberOfDoors;
        }

        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set
            {
                if (value == 2 || value == 4)
                {
                    numberOfDoors = value;
                }
                else
                {
                    numberOfDoors = -1;
                    Console.WriteLine("Kapı sayısı 2 veya 4 olarak ayarlanmalıdır!");
                }
            }
        }

        public void GetCarDetail()
        {
            Console.WriteLine();
            Console.WriteLine($"Marka: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Renk: {Color}");
            if (NumberOfDoors > 0) Console.WriteLine($"Kapı Sayısı: {NumberOfDoors}");
            Console.WriteLine();
        }
    }
}