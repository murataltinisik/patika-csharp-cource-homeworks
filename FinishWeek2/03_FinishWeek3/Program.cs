// Random Number
void getNumber ()
{
    // Random
    Random random = new Random();

    // Number
    int number = random.Next (0, 1000);

    // Write
    Console.WriteLine (number);
}

// Call Method
getNumber();