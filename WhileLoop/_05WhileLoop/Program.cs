// Variables
int counter = 1;
int totalOddNumber = 0, totalEvenNumber = 0;

// Loop
while (counter >= 1 && counter <= 120) {
    if(counter % 2 == 0) {
        totalEvenNumber += counter;
    } else {
        totalOddNumber += counter;
    }
    counter++;
}

// Write Console
Console.WriteLine("------------------------------");
Console.WriteLine($"Total of odd number: {totalOddNumber}");
Console.WriteLine($"Total of even number: {totalEvenNumber}");
Console.WriteLine("------------------------------");