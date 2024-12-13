using Microsoft.EntityFrameworkCore;
using Survivor.Models.Entities;

namespace Survivor.Models.Contexts;

public class DatabaseContext : DbContext
{
    // Tables
    public DbSet<Category> Categories { get; set; }
    public DbSet<Competitor> Competitors { get; set; }
    
    // IConfiguration
    private readonly IConfiguration _configuration;
    
    // Initial Configuration
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
    
    // Seed Data
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Category Seed Data
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Ünlüler", IsDeleted = false, CreatedAt = DateTime.Parse("2024-01-01 10:00:00"), UpdatedAt = DateTime.Parse("2024-01-01 10:00:00") },
            new Category { Id = 2, Name = "Gönüllüler", IsDeleted = false, CreatedAt = DateTime.Parse("2024-01-01 10:00:00"), UpdatedAt = DateTime.Parse("2024-01-01 10:00:00") }
        );

        // Competitor Seed Data
        modelBuilder.Entity<Competitor>().HasData(
            new Competitor { Id = 1, FirstName = "Acun", LastName = "Ilıcalı", CategoryId = 1, IsDeleted = false, CreatedAt = DateTime.Parse("2024-01-01 10:00:00"), UpdatedAt = DateTime.Parse("2024-01-01 10:00:00") },
            new Competitor { Id = 2, FirstName = "Aleyna", LastName = "Avcı", CategoryId = 1, IsDeleted = false, CreatedAt = DateTime.Parse("2024-01-01 10:00:00"), UpdatedAt = DateTime.Parse("2024-01-01 10:00:00") },
            new Competitor { Id = 3, FirstName = "Hadise", LastName = "Açıkgöz", CategoryId = 1, IsDeleted = false, CreatedAt = DateTime.Parse("2024-01-01 10:00:00"), UpdatedAt = DateTime.Parse("2024-01-01 10:00:00") },
            new Competitor { Id = 4, FirstName = "Sertan", LastName = "Bozkuş", CategoryId = 1, IsDeleted = false, CreatedAt = DateTime.Parse("2024-01-01 10:00:00"), UpdatedAt = DateTime.Parse("2024-01-01 10:00:00") },
            new Competitor { Id = 5, FirstName = "Özge", LastName = "Açık", CategoryId = 1, IsDeleted = false, CreatedAt = DateTime.Parse("2024-01-01 10:00:00"), UpdatedAt = DateTime.Parse("2024-01-01 10:00:00") },
            new Competitor { Id = 6, FirstName = "Kıvanç", LastName = "Tatlıtuğ", CategoryId = 1, IsDeleted = false, CreatedAt = DateTime.Parse("2024-01-01 10:00:00"), UpdatedAt = DateTime.Parse("2024-01-01 10:00:00") },
            new Competitor { Id = 7, FirstName = "Ahmet", LastName = "Yılmaz", CategoryId = 2, IsDeleted = false, CreatedAt = DateTime.Parse("2024-01-01 10:00:00"), UpdatedAt = DateTime.Parse("2024-01-01 10:00:00") },
            new Competitor { Id = 8, FirstName = "Elif", LastName = "Demirtaş", CategoryId = 2, IsDeleted = false, CreatedAt = DateTime.Parse("2024-01-01 10:00:00"), UpdatedAt = DateTime.Parse("2024-01-01 10:00:00") },
            new Competitor { Id = 9, FirstName = "Cem", LastName = "Öztürk", CategoryId = 2, IsDeleted = false, CreatedAt = DateTime.Parse("2024-01-01 10:00:00"), UpdatedAt = DateTime.Parse("2024-01-01 10:00:00") },
            new Competitor { Id = 10, FirstName = "Ayşe", LastName = "Karaca", CategoryId = 2, IsDeleted = false, CreatedAt = DateTime.Parse("2024-01-01 10:00:00"), UpdatedAt = DateTime.Parse("2024-01-01 10:00:00") }
        );

        base.OnModelCreating(modelBuilder);
    }
}