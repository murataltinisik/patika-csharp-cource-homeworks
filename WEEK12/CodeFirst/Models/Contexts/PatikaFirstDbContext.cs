using CodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Models.Contexts;

public class PatikaFirstDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public PatikaFirstDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SqlServer"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>()
            .Property(g => g.Rating)
            .HasPrecision(18, 2);
    }

    public DbSet<Game> Games { get; set; }
    public DbSet<Movie> Movies { get; set; }
}