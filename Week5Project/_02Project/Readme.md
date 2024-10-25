# Pratik - Lists 1

This is a `List<>` homework. 

```csharp
// Start
Console.WriteLine("Program'dan çıkış yapmak için (q) basın");
Console.WriteLine();

// Define List
List<string> guests = new List<string>();

// Get Values and push array
do
{
    // Get Value
    Console.Write("Please enter a guest name: ");
    string input = Console.ReadLine();

    if (input == "q") break;
    
    // Add item to list
    guests.Add(input);
} while (true);

// Write Console
Console.WriteLine();
Console.WriteLine("------- DAVETLİLER -------");
Console.WriteLine("--------------------------");
for (int i = 0; i < guests.Count; i++) 
    Console.WriteLine("{0} - {1}", i+1, guests[i]);
```