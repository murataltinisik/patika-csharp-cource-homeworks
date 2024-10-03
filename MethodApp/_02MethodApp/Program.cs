int ReturnIntegerValue() {
    // Random
    Random random = new Random();

    // Random Number
    int randomNumber = random.Next(1, 1000);

    // Finish
    return randomNumber % 2;
}

// Bence double olarak döndürmek daha iyi gibi.

Console.WriteLine($"Cevap: {ReturnIntegerValue()}");