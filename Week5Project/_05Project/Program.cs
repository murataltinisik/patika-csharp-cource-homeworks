try
{
    // Get Value
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    // Write Console
    Console.WriteLine("Result: {0}", number * number);
}
catch (Exception ex)
{
    Console.WriteLine("Invalid Input, please try again.");
}

