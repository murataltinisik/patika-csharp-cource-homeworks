using IdentityDataProtection.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdentityDataProtection.Models.Context;

public class DatabaseContext : DbContext
{
    // Define Tables
    public DbSet<User> Users { get; set; }
    
    // 
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}
}