using _02Project;

// Variables
List<Album> albums = new List<Album>
{
    new Album("Ajda", "Pekkan",  "Pop", 1968, 20),
    new Album("Sezen", "Aksu",  "Pop/Türk Halk Müziği", 1971, 10),
    new Album("Funda", "Arar",  "Pop", 1999, 3),
    new Album("Sertab", "Erener",  "Pop", 1994, 5),
    new Album("Sıla", "",  "Pop", 2009, 3),
    new Album("Serdar", "Ortaç",  "Pop", 1994, 10),
    new Album("Tarkan", "",  "Pop", 1992, 40),
    new Album("Hande", "Yener",  "Pop", 1999, 7),
    new Album("Hadise", "",  "Pop", 2005, 5),
    new Album("Gülben", "Ergen",  "Pop/Türk Halk Müziği", 1997, 10),
    new Album("Neşet", "Ertaş",  "Türk Halk/Sanat Müziği", 1960, 2),
};

// StartWidth('S')
foreach (Album album in albums.Where(a => a.SingerName.StartsWith('S'))) Console.WriteLine(album);

Console.WriteLine("-------------------------");

// more than 10 milyon sales
foreach (Album album in albums.Where(a => a.AlbumSales > 10)) Console.WriteLine(album);

Console.WriteLine("-------------------------");

// before "2000" year, and music type equal "POP"
var groupedAlbums = from album in albums
    where album.AlbumYear < 2000 && album.MusicType == "Pop"
    orderby album.AlbumYear
    group album by album.AlbumYear
    into yearGroup
    select new {
        AlbumYear = yearGroup.Key,
    };
    
foreach (var item in groupedAlbums) Console.WriteLine(item.AlbumYear);

Console.WriteLine("-------------------------");

// Best selling album
Album bestSellingAlbum = (from album in albums orderby album.AlbumSales descending select album).ToList().First();
Console.WriteLine(bestSellingAlbum);

// New and Old Singer
Album newAlbum = albums.OrderBy(a => a.AlbumYear).ToList().Last();
Album oldAlbum = albums.OrderBy(a => a.AlbumYear).ToList().First();

Console.WriteLine("------------------------");
Console.WriteLine(oldAlbum);
Console.WriteLine(newAlbum);

