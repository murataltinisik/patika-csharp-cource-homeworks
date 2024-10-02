// Variables
int totalOddNumber = 0;
int totalEvenNumber = 0;

// Loop
for(int i = 1; i<=120; i++) {
    if(i % 2 == 0) {
        totalEvenNumber += i;
    } else {
        totalOddNumber += i;
    }
}

// Result
Console.WriteLine("--------------------------------");
Console.WriteLine($"Total of odd numbers: {totalOddNumber}");
Console.WriteLine($"Total of even numbers: {totalEvenNumber}");
Console.WriteLine("--------------------------------");