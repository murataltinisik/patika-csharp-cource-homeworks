// ------------------------------------------------------------------------
// ------------------------------- DO WHILE -------------------------------
// ------------------------------------------------------------------------

// Variables
int limit = 0;
int counter = 0;
bool isNumber = false;

// Check input is number
do {
    Console.Write("Limit Giriniz: ");
    isNumber = int.TryParse(Console.ReadLine(), out limit);

    if(!isNumber || limit == 0) {
        Console.WriteLine("Girilen Değer Sayısal değil ya da 0'a eşit!!!");
        Console.WriteLine("------------------------------");
        Console.WriteLine();
    }
} while (!isNumber || limit == 0);

// Write Values
if(limit > 0) {
    while (counter <= limit)
    {
        Console.WriteLine("Ben bir Patika'lıyım");
        counter++;
    }
} else {
    while (counter >= limit)
    {
        Console.WriteLine("Ben bir Patika'lıyım");
        counter--;
    }
}
