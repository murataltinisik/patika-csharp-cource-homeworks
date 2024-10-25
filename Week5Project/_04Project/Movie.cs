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