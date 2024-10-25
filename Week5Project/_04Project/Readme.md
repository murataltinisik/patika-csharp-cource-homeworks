# Pratik - IMDB Listesi

![](https://store.patika.dev/sertanbozkus/cohorts/patika-back-end-web-developer-programi-net-template/tasks/rb8UGD1SkF3Utro9P/BXy5S-K-movie-9pvmdtvz4cb0xl37.jpgLbguBk8r)

![](https://store.patika.dev/sertanbozkus/cohorts/patika-back-end-web-developer-programi-net-template/tasks/rb8UGD1SkF3Utro9P/YxJF9NG-imdblist.pngYlFbh-0T)

### Aşağıda belirtilen adımları gerçekleştirerek bir Imdb - Film Listesi oluşturuyoruz.
1. Sinema Filmlerini listeleyeceğimiz bir liste oluşturalım.
2. Film için propertyler -> Imdb Puanı (Double) - İsmi
3. Kullanıcıdan sınırsız sayıda film adı ve imdb puanı isteyip bu bilgilerle nesneler oluşturulup liste doldurulacak.
4. Kullanıcıya her film eklemesinden sonra yeni bir film eklemek isteyip istemediği sorulsun. Kullanıcı evet cevabını verirse döngüde başa dönülerek yeni bir film oluşturulup ilgili listeye aktarılsın. Hayır cevabı verilirse program aşağıdaki çıktıları ayrı ayrı sunarak sonlandırılsın.

### Uygulamanın sonunda
1. Bütün filmler listelensin.
2. Imdb puanı 4 ile 9 arasında olan bütün filmler listelensin.
3. İsmi 'A' ile başlayan filmler ve imdb puanları listelensin.

#### Movie Class
```csharp
namespace _04Project;

public class Movie
{
    private double _point;
    
    public double Point
    {
        get { return _point; }
        set
        {
            if (value < 0 || value > 10)
            {
                Console.WriteLine("Point değeri 0'dan küçük ve ya 10'dan büyük olamaz.");
            }
            else
            {
                _point = value; 
            }
        }
    }

    public string Title { get; set; }

    public Movie(string title, double point)
    {
        Title = title;
        Point = point;
    }

    public override string ToString()
    {
        return $"Film Adı: {Title} - IMBD: {Point}";
    }
}
```

#### Usage
```csharp
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
```