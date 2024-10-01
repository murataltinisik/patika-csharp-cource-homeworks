using System;

namespace ControlStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set App Name
            Console.Title = "Control Structure";

            // Initial Value
            int number = 0;

            // Get Input Value
            Console.Write("Lütfen bir değer giriniz: ");
            string input = Console.ReadLine();

            // Is input value number
            bool isNumber = int.TryParse(input, out number);

            // Check Value
            if (isNumber){
                if (number > 10) {
                    Console.WriteLine("Girilen değer 10'dan büyüktür.");
                } else if (number < 10) {
                    Console.WriteLine("Girilen değer 10'dan küçüktür.");
                } else { 
                    Console.WriteLine("Girilen değer 10'a eşittir.");
                }

                // Write is number couple or single
                Console.WriteLine(number % 2 == 0 ? "Girilen Sayı Çifttir." : "Girilen Sayı Tektir.");
            } else{
                Console.WriteLine("Girilen değer geçersiz formatta!");
            }
        }
    }
}