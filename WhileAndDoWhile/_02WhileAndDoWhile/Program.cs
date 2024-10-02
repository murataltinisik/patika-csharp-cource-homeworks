// ------------------------------------------------------------------------
// --------------------------------- WHILE --------------------------------
// ------------------------------------------------------------------------

// Variables
int limit = 0;
int counter = 0;
bool isNumber = false;

// Get Value
Console.Write("Limit Giriniz: ");
isNumber = int.TryParse(Console.ReadLine(), out limit);

while (!isNumber || limit == 0) {
    Console.WriteLine();
    Console.WriteLine("Girilen Değer Sayısal değil ya da 0'a eşit!!!");
    Console.Write("Tekrar Limit Giriniz: ");
    isNumber = int.TryParse(Console.ReadLine(), out limit);
}

// Write Values
if (limit > 0) {
    while (counter <= limit) {
        Console.WriteLine("Ben bir Patika'lıyım");
        counter++;
    }
}
else {
    while (counter >= limit) {
        Console.WriteLine("Ben bir Patika'lıyım");
        counter--;
    }
}
