using _04Project;

// Define List
List<Movie> movies = new List<Movie>();

// Get Values and push item to list
do
{
    // Get Value
    Console.Write("Enter Movie Title: ");
    string title = Console.ReadLine();
    
    // Title is Empty
    if (string.IsNullOrEmpty(title))
    {
        Console.WriteLine("Please, enter a title!!! ");
        continue;
    }
    
    Console.Write("Enter Movie IMDB Point: ");
    bool isNumeric = double.TryParse(Console.ReadLine(), out double imdbPoint);
    
    // Point is not numeric
    if (!isNumeric)
    {
        Console.WriteLine("Invalid Imdb Point. Try again.");
        continue;
    }
    
    // Create new object (movie)
    Movie movie = new Movie(title, imdbPoint);
    
    // Add movie to list
    movies.Add(movie);
    
    // Do you want to add a movie
    Console.WriteLine();
    Console.Write("Do you want to add a movie? (y/n): ");
    string isContinue = Console.ReadLine();

    // Exit Program
    if (isContinue == "n") break;
} while (true);

// Write All Movies
Console.WriteLine("ALL MOVIES");
foreach (Movie movie in movies) Console.WriteLine(movie);
Console.WriteLine("-------------------");

// Write All Movies Where IMBD between 4 and 9
Console.WriteLine("BETWEEN 4 and 9 - MOVIES");
List<Movie> filteredWhereBetween = movies.Where(movie => movie.Point >= 4 && movie.Point <= 9).ToList();
foreach (Movie movie in filteredWhereBetween) Console.WriteLine(movie);
Console.WriteLine("-------------------");

// Write All Movies Where Title LIKE 'a%'
Console.WriteLine("Is Start With 'a' Title - MOVIES");
List<Movie> filteredTitleStartWith = movies.Where(movie => movie.Title.StartsWith('A')).ToList();
foreach (Movie movie in filteredTitleStartWith) Console.WriteLine(movie);
Console.WriteLine("-------------------");
