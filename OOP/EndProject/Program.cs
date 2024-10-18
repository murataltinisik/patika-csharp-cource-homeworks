using System;
using OOP;

namespace EndProject
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            // Start Project
            Console.WriteLine("----------- ÜRET -----------");
            Console.WriteLine("(1) -> Bilgisayar");
            Console.WriteLine("(2) -> Telefon");
            Console.WriteLine("----------------------------");

            // Product Type
            int productType = SelectProductType();

            // Product Properties
            Console.WriteLine();
            Console.WriteLine("------ ÜRÜN BİLGİLERİ ------");

            Console.Write("Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Ürün Açıklaması: ");
            string productDescription = Console.ReadLine();

            Console.Write("Ürün Seri Numarası: ");
            string productSerialNumber = Console.ReadLine();

            Console.Write("Ürün İşletim Sistemi: ");
            string productOperatingSystem = Console.ReadLine();

            if (productType == 1)
            {
                // Get Speacial Properties of Computer
                Console.Write("Ürün USB Sayısı: ");
                int productUSBNumbers = int.Parse(Console.ReadLine());

                // Create Computer
                Computer computer = new Computer(productName, productDescription, productSerialNumber, productOperatingSystem, productUSBNumbers);

                // Print Computer Value
                computer.PrintInformations();
            }
            else if (productType == 2)
            {
                // Variable
                bool isLicence = false;

                // Get Speacial Properties of Phone
                Console.Write("Ürün Lisansı Var mı (Evet/Hayır): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "evet") isLicence = true;

                // Create Phone
                Phone phone = new Phone(productName, productDescription, productSerialNumber, productOperatingSystem, isLicence);

                // Print Phone Value
                phone.PrintInformations();
            }

            // Restart App
            Console.WriteLine();
            Console.Write("Yeni Bir ürün üretmek istiyor musunuz? (e/h): ");
            string newProduct = Console.ReadLine();

            if (newProduct.ToLower() == "e") goto start;

            // Finish App
            Console.WriteLine("İyi Günler..... :)");
        }

        public static int SelectProductType()
        {
            // Create Variable
            int value = 0;

            // Loop, for get valid value
            do
            {
                // Get Values
                Console.Write("Seçiniz (1/2): ");

                // Is valid input value 
                bool isValid = int.TryParse(Console.ReadLine(), out value);

                // If value is not valid, again loop
                if (!isValid)
                {
                    Console.WriteLine("Girilen Değer Geçersiz, Lütfen (1/2) doğru bir değer giriniz!!");
                    continue;
                }

                // Control Input Value
                switch (value)
                {
                    case 1:
                        value = 1;
                        return value;
                        break;
                    case 2:
                        value = 2;
                        return value;
                        break;
                    default:
                        Console.WriteLine("Geçersiz Değer, Lütfen (1/2) doğru bir değer giriniz!");
                        continue;
                }
            } while (value != 1 || value != 2);

            return value;
        }

    }
}