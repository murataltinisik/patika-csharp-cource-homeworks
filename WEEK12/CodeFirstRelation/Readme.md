# Practical - Code First Relation

This project involves creating a database and relationships using **Code First** approach with Entity Framework Core. The project defines **User** and **Post** tables, establishing a one-to-many relationship between them.

## Database Structure

### User Table:
- **Id**: `int`, primary key, and auto-incremented.
- **Username**: `string`, username of the user.
- **Email**: `string`, email address of the user.

### Post Table:
- **Id**: `int`, primary key, and auto-incremented.
- **Title**: `string`, title of the post.
- **Content**: `string`, content of the post.
- **UserId**: `int`, author of the post (user's ID).

### Relationship
- A **User** can have multiple **Posts**.
- Each **Post** belongs to a single **User**.

## Project Structure

```
ProjectName/
├── Controllers/
├── Models/
│   ├── User.cs
│   ├── Post.cs
├── Data/
│   ├── PatikaSecondDbContext.cs
├── Migrations/
├── Program.cs
├── appsettings.json
```

## Requirements

To run this project, ensure you have the following installed:
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/sql-server)

## Setup

### 1. Install Dependencies
```bash
dotnet restore
```

### 2. Configure the Database
- Update the `ConnectionStrings` section in **appsettings.json**:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost,1433;Database=PatikaCodeFirstDb2;Encrypt=False;User Id=sa;Password=[YOUR_PASSWORD];TrustServerCertificate=True;"
}
```

### 4. Apply Migrations
```bash
dotnet ef migrations add InitialMigration
dotnet ef database update
```

## Usage

### Models

#### User Model:
```csharp
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }

    public List<Post> Posts { get; set; }
}
```

#### Post Model:
```csharp
public class Post
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public User User { get; set; }
}
```

### DbContext

```csharp
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
```