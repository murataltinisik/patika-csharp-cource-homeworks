using JWTProject.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace JWTProject.Models.Contexts;

public class DatabaseContext : DbContext
{   
    // Define Tables
    public DbSet<User> Users { get; set; }
    
    // Database Context
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
}