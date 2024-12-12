using CodeFirstRelation.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelation.Models.Contexts;

public class PatikaSecondDbContext : DbContext
{
  // Tables
  public DbSet<User> Users { get; set; }
  public DbSet<Post> Posts { get; set; }
  
  // Configuration
  private readonly IConfiguration _configuration;
  
  // Initialize Configuration DbContext
  public PatikaSecondDbContext(IConfiguration configuration)
  {
    _configuration = configuration;
  }

  // Connect to Database
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SqlServer"));
  }
}