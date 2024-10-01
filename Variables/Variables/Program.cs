using System;

namespace Variables 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set App Title
            Console.Title = "The App with Variables";

            // Start
            Console.WriteLine("Lütfen bilgilerinizi giriniz!");

            // Get Input Values
            Console.Write("TC Kimlik: ");
            string identity = Console.ReadLine();

            Console.Write("Adınız: ");
            string name = Console.ReadLine();

            Console.Write("Soyadınız: ");
            string surname = Console.ReadLine();

            Console.Write("Telefon Numaranız: ");
            string phone = Console.ReadLine();  

            Console.Write("Yaş: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ilk Ürün Fiyat: ");
            double firstOfProductPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci Ürün Fiyat: ");
            double secondOfProductPrice = Convert.ToDouble(Console.ReadLine());

            // Result and Write Console
            double totalOfProductPrice = firstOfProductPrice + secondOfProductPrice;

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"{identity} tc kimlik numaralı {name} {surname} adlı kişi için kayıt oluşturulmuştur.");
            Console.WriteLine($"{phone} telefon numarasına bildirim mesajı gönderilmiştir.");
            Console.WriteLine($"{totalOfProductPrice} toplam harcama karşılığı kazanılan 10% patika puan miktarı -> {totalOfProductPrice * 0.10} TL'dir.");
        }
    }
}