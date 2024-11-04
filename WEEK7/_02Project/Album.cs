namespace _02Project;

public class Album
{
    public int AlbumYear { get; set; }
    public int AlbumSales { get; set; }
    public string MusicType { get; set; }
    public string SingerName { get; set; }
    public string SingerSurname { get; set; }

    public Album(string singerName, string? singerSurname, string musicType, int albumYear, int albumSales)
    {
        SingerName = singerName;
        SingerSurname = singerSurname;
        MusicType = musicType;
        AlbumYear = albumYear;
        AlbumSales = albumSales;
    }

    public override string ToString()
    {
        return $"Şarkıcı Adı: {SingerName}\n" +
               $"Şarkıcı Soyad: {SingerSurname}\n" +
               $"Albüm Yılı: {AlbumYear}\n" +
               $"Müzik Türü: {MusicType}\n" +
               $"Satışlar: Yaklaşık {AlbumSales} milyon\n";
    }
}