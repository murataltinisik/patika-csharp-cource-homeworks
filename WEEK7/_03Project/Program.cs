using _03Project;

// Define List Variables
List<Series> series = new List<Series>();

/*
 * public string Name { get; set; }
      public string Type { get; set; }
      public string Director { get; set; }
      public int StartingYear { get; set; }
      public int YearOfProduction { get; set; }
      public string PublishedFirstPlatform { get; set; }
 */

do
{
    // Enter Values for Series
    Console.Write("Enter series name: ");
    string seriesName = Console.ReadLine();
    
    Console.Write("Enter series type: ");
    string seriesType = Console.ReadLine();
    
    Console.Write("Enter series director: ");
    string seriesDirector = Console.ReadLine();
    
    AgainGetSeriesStartingYear:
    Console.Write("Enter series starting year: ");
    bool isSeriesStartingYearNumeric = int.TryParse(Console.ReadLine(), out int seriesStartingYear);

    if (!isSeriesStartingYearNumeric)
    {
        Console.WriteLine("Please, enter a valid starting year value!");
        Console.WriteLine();
        goto AgainGetSeriesStartingYear;
    }
    
    AgainGetYearOfProduction:
    Console.Write("Enter year of production: ");
    bool isSeriesYearOfProductionNumeric = int.TryParse(Console.ReadLine(), out int seriesYearOfProduction);
    
    if (!isSeriesYearOfProductionNumeric)
    {
        Console.WriteLine("Please, enter a valid year of production value!");
        Console.WriteLine();
        goto AgainGetYearOfProduction;
    }
    
    Console.Write("Enter published first platform: ");
    string seriesPublishedFirstPlatform = Console.ReadLine();
    
    // Add item to series list
    Series item = new Series(seriesName, seriesType, seriesDirector, seriesStartingYear, seriesYearOfProduction, seriesPublishedFirstPlatform);
    series.Add(item);
    
    // Write Success Message
    Console.WriteLine("Created Series Successfully...");
    Console.WriteLine("---------- CREATED SERIES ----------");
    Console.WriteLine(item);
    Console.WriteLine("------------------------------------");
    Console.WriteLine();
    
    // Ask question to user "continue" and "finish"
    Console.Write("Do you want to continue? (y/n): ");
    string input = Console.ReadLine().ToLower();

    // Exit Loop
    if (input == "n") break;
} while(true);

// Write Series
Console.WriteLine();
Console.WriteLine("-------------------");

var dataSource = series
    .OrderByDescending(s => s.Name)
    .OrderByDescending(s => s.Director);

foreach (var data in dataSource) Console.WriteLine(data);
