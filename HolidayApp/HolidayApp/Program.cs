// Variables
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

string answer;
int totalPrice = 0;
int numberOfPerson = 0;
Location selectedLocation;
TravelOptions travelOption;


// Holiday Options
Console.WriteLine("------------- HOŞGELDİNİZ -------------");
Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)");
Console.WriteLine("2 - Marmaris (Paket başlangıç fiyatı 3000 TL)");
Console.WriteLine("3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");
Console.WriteLine("---------------------------------------");
Console.WriteLine();

// Loop
do {
    // Get Value
    Console.Write("Bir Lokasyon Seçiniz: ");
    string input = Console.ReadLine().ToUpper();
    Console.WriteLine("---------------------------------------");

    // Is value location enum
    bool isLocation = Enum.TryParse(input, true, out Location location);

    // Location is empty or not defined -> continue
    if (!isLocation) continue;

    // Location Select Control
    switch (location)
    {
        case Location.BODRUM:
            selectedLocation = Location.BODRUM;
            break;
        case Location.MARMARIS:
            selectedLocation = Location.MARMARIS;
            break;
        case Location.CESME:
            selectedLocation = Location.CESME;
            break;
        default:
            continue;
    }

    // is selected location, break;
    if (selectedLocation != null) break;
} while (true);


do
{
    // Enter, How many person?
    Console.WriteLine();
    Console.Write("Kaç Kişilik bir tatil olacak: ");
    bool isNumber = int.TryParse(Console.ReadLine(), out numberOfPerson);

    // Check is number
    if (isNumber)
    {
        if (numberOfPerson > 0) { break; } else { continue; }
    }
    else
    {
        continue;
    }
} while (true);


do
{
    // Select Travel Option
    Console.WriteLine();
    Console.WriteLine("-------- YOLCULUK SEÇENEKLERİ --------");
    Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
    Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
    Console.Write(" Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz (1/2): ");
    string travel = Console.ReadLine();

    // Travel is selected
    if (travel == "1")
    {
        travelOption = TravelOptions.KARAYOLU;
        break;
    }
    else
    {
        travelOption = TravelOptions.HAVAYOLU;
        break;
    }

    // is not selected
    Console.WriteLine("Bir hata oluştu lütfen tekrar giriniz :)");
} while (true);


// Holiday Information
Console.WriteLine();
totalPrice = ((int)selectedLocation * numberOfPerson) + ((int)travelOption * numberOfPerson);
Console.WriteLine("------------ TATİL BİLGİLERİNİZ ------------");
Console.WriteLine($"LOKASYON: {selectedLocation}.");
Console.WriteLine($"KAÇ KİŞİLİK: {numberOfPerson} Kişi.");
Console.WriteLine($"YOLCULUK TÜRÜ: {travelOption}.");
Console.WriteLine($"Toplam Fiyat: {totalPrice} TL");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();


// Holiday Information
Console.Write("Yeni bir tatil planlamak istiyormusunuz? (Evet, Hayır)");
answer = Console.ReadLine().ToUpper();

if (answer == "HAYIR")
{
    Environment.Exit(0);
}
else
{
    Process.Start(Process.GetCurrentProcess().MainModule.FileName);
    Environment.Exit(0);
}

// Enums
enum Location { BODRUM = 4000, MARMARIS = 3000, CESME = 5000 };
enum TravelOptions { KARAYOLU = 1500, HAVAYOLU = 4000 };


/*
    https://stackoverflow.com/questions/5682408/command-to-close-an-application-of-console
    baktım, Environment.Exit(0)
    
    Bu koda -> CHATGPT BAKTIM = Process.Start(Process.GetCurrentProcess().MainModule.FileName);

    Bunlara alternatif olarak do-while ile hepsini kapsayıp da yapabilirdim, biraz araştırıp
    farklı bir yöntem ile denemetim, do-while while(answer == "EVET")

    oda aşağıda gibi olacak.

do {

    // Holiday Options
    Console.WriteLine("------------- HOŞGELDİNİZ -------------");
    Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)");
    Console.WriteLine("2 - Marmaris (Paket başlangıç fiyatı 3000 TL)");
    Console.WriteLine("3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine();

    // Loop
    do
    {
        // Get Value
        Console.Write("Bir Lokasyon Seçiniz: ");
        string input = Console.ReadLine().ToUpper();
        Console.WriteLine("---------------------------------------");

        // Is value location enum
        bool isLocation = Enum.TryParse(input, true, out Location location);

        // Location is empty or not defined -> continue
        if (!isLocation) continue;

        // Location Select Control
        switch (location)
        {
            case Location.BODRUM:
                selectedLocation = Location.BODRUM;
                break;
            case Location.MARMARIS:
                selectedLocation = Location.MARMARIS;
                break;
            case Location.CESME:
                selectedLocation = Location.CESME;
                break;
            default:
                continue;
        }

        // is selected location, break;
        if (selectedLocation != null) break;
    } while (true);


    do
    {
        // Enter, How many person?
        Console.WriteLine();
        Console.Write("Kaç Kişilik bir tatil olacak: ");
        bool isNumber = int.TryParse(Console.ReadLine(), out numberOfPerson);

        // Check is number
        if (isNumber)
        {
            if (numberOfPerson > 0) { break; } else { continue; }
        }
        else
        {
            continue;
        }
    } while (true);


    do
    {
        // Select Travel Option
        Console.WriteLine();
        Console.WriteLine("-------- YOLCULUK SEÇENEKLERİ --------");
        Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
        Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
        Console.Write(" Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz (1/2): ");
        string travel = Console.ReadLine();

        // Travel is selected
        if (travel == "1")
        {
            travelOption = TravelOptions.KARAYOLU;
            break;
        }
        else
        {
            travelOption = TravelOptions.HAVAYOLU;
            break;
        }

        // is not selected
        Console.WriteLine("Bir hata oluştu lütfen tekrar giriniz :)");
    } while (true);


    // Holiday Information
    Console.WriteLine();
    totalPrice = ((int)selectedLocation * numberOfPerson) + ((int)travelOption * numberOfPerson);
    Console.WriteLine("------------ TATİL BİLGİLERİNİZ ------------");
    Console.WriteLine($"LOKASYON: {selectedLocation}.");
    Console.WriteLine($"KAÇ KİŞİLİK: {numberOfPerson} Kişi.");
    Console.WriteLine($"YOLCULUK TÜRÜ: {travelOption}.");
    Console.WriteLine($"Toplam Fiyat: {totalPrice} TL");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();


    // Holiday Information
    Console.Write("Yeni bir tatil planlamak istiyormusunuz? (Evet, Hayır)");
    answer = Console.ReadLine().ToUpper();
} while (answer == "EVET");
*/