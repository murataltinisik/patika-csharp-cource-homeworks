Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.DarkBlue;

// Start
Console.WriteLine("Programdan çıkış yapmak için (q) basın.");

// Define List 
List<string> coffees = new List<string>();

// Get value and put item to list
do
{
    // Does the list have 5 elements?
    if (coffees.Count == 5) break;
    
    // Get Value
    Console.Write("Enter coffee name: ");
    string input = Console.ReadLine();
    
    // Is Exit Value
    if (input == "q") break;
    
    // Input is empty
    if (string.IsNullOrEmpty(input)) continue;
    
    // Add item to list
    coffees.Add(input);
} while (true);

// Write Console
Console.WriteLine();
Console.WriteLine("------------ KAHVELER ------------");
foreach (string coffe in coffees) Console.WriteLine(coffe);
