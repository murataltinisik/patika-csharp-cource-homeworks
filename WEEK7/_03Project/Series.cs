namespace _03Project;

public class Series
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string Director { get; set; }
    public int StartingYear { get; set; }
    public int YearOfProduction { get; set; }
    public string PublishedFirstPlatform { get; set; }

    public Series(string name, string type, string director, int startingYear, int yearOfProduction, string publishedFirstPlatform)
    {
        Name = name;
        Type = type;
        Director = director;
        StartingYear = startingYear;
        YearOfProduction = yearOfProduction;
        PublishedFirstPlatform = publishedFirstPlatform;
    }

    public override string ToString()
    {
        return $"Film Ad: {Name}\n" +
               $"Film Tür: {Type}\n" +
               $"Film Yönetmen: {Director}\n" +
               $"Başlangıç Tarih: {StartingYear}\n" +
               $"Yapım Yıl: {YearOfProduction}\n" +
               $"Yayınlandığı İlk Platform: {PublishedFirstPlatform}\n";
    }
}