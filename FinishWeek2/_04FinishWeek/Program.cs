// Random Number
void findMod()
{
    // Random
    Random random = new Random();

    // Number
    int number = random.Next(1, 1000);

    // Result 
    double result = number % 3;

    // Write
    Console.WriteLine($"Kalan: {result}");
}

// Call Method
findMod();