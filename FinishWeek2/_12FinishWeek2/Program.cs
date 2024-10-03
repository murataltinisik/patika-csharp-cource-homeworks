// Method
int findMaxValue(in int[] numbers) {
    return numbers.Max();
}

// Variables
int index = 0;
int[] numbers = new int[100];

// 
Console.WriteLine("---------");
Console.WriteLine("Çıkış yapmak için bir tuşa basın!");
Console.WriteLine("---------");
Console.WriteLine();

do
{
    // Get Values
    Console.WriteLine();
    Console.Write($"{index+1}. Sayı: ");
    bool inputIsNumber = int.TryParse(Console.ReadLine(), out int number);

    // Calculate
    if (inputIsNumber) {
        if(number > 0) {
            numbers[index] = number;
        }
    } else {
        break;
    }

    index++;
} while (true);

// Finish
Console.WriteLine();
Console.WriteLine("------------- EN BÜYÜK SAYI -------------");
Console.WriteLine(findMaxValue(numbers));
Console.WriteLine("-----------------------------------------");
Console.WriteLine();