# Pratik - Array 1

This is a `array` homework. 

```csharp
// Define integer array [10]
int[] array = new int[10];

// Get value and put item to array
for (int i = 0; i < array.Length; )
{
    // Get Value
    Console.Write("Enter number: ");
    bool isNumber = int.TryParse(Console.ReadLine(), out int number);

    if (isNumber)
    {
        array[i] = number;
        i++;
    }
    else
    {
        Console.WriteLine("Please enter a number");
        continue;
    }
}

// Sort array
Array.Sort(array);

// Write Values
Console.WriteLine(string.Join(", ", array));
```