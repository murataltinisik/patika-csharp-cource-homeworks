# Survivor API Project

This project demonstrates the implementation of an ASP.NET Core Web API using **Entity Framework Core** with a focus on a **Code First** approach. The API manages `Categories` and `Competitors` entities with related CRUD operations.

## Project Overview

### Entities

#### **Category**
- **Id**: Primary key (int, auto-incremented).
- **Name**: Name of the category (required, max length 100).
- **IsDeleted**: Soft delete flag (default: `false`).
- **CreatedAt**: Creation timestamp (default: `DateTime.Now`).
- **UpdatedAt**: Last update timestamp (default: `DateTime.Now`).

#### **Competitor**
- **Id**: Primary key (int, auto-incremented).
- **CategoryId**: Foreign key referencing `Category` (required).
- **FirstName**: First name of the competitor (required, max length 50).
- **LastName**: Last name of the competitor (required, max length 50).
- **IsDeleted**: Soft delete flag (default: `false`).
- **CreatedAt**: Creation timestamp (default: `DateTime.Now`).
- **UpdatedAt**: Last update timestamp (default: `DateTime.Now`).

### Project Structure

```
Survivor/
├── Controllers/
│   ├── Category/
│   │   └── CategoriesController.cs
│   ├── Competitor/
│   │   ├── CompetitorsController.cs
│   │   └── IController.cs
├── Migrations/
├── Models/
│   ├── Contexts/
│   │   └── DatabaseContext.cs
│   ├── DTOs/
│   │   ├── CategoryDto.cs
│   │   └── CompetitorDto.cs
│   └── Entities/
│       ├── Category.cs
│       └── Competitor.cs
├── appsettings.json
├── appsettings.Development.json
├── Program.cs
├── README.md
└── Survivor.http
```

### Controllers

#### **CategoriesController**
Handles CRUD operations for `Category`:
- **`GET /api/categories`**: Retrieves all categories.
- **`GET /api/categories/{id}`**: Retrieves a specific category by its ID.
- **`POST /api/categories`**: Adds a new category.
- **`PUT /api/categories/{id}`**: Updates an existing category.
- **`DELETE /api/categories/{id}`**: Soft deletes a category.

#### **CompetitorsController**
Handles CRUD operations for `Competitor`:
- **`GET /api/competitors`**: Retrieves all competitors.
- **`GET /api/competitors/{id}`**: Retrieves a specific competitor by its ID.
- **`GET /api/competitors/categories/{id}`**: Retrieves all competitors under a specific category.
- **`POST /api/competitors`**: Adds a new competitor.
- **`PUT /api/competitors/{id}`**: Updates an existing competitor.
- **`DELETE /api/competitors/{id}`**: Soft deletes a competitor.

### Database Context

#### **DatabaseContext**
This context manages the `Categories` and `Competitors` tables:
```csharp
public class DatabaseContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Competitor> Competitors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Ünlüler", IsDeleted = false },
            new Category { Id = 2, Name = "Gönüllüler", IsDeleted = false }
        );

        modelBuilder.Entity<Competitor>().HasData(
            new Competitor { Id = 1, FirstName = "Acun", LastName = "Ilıcalı", CategoryId = 1 },
            new Competitor { Id = 2, FirstName = "Aleyna", LastName = "Avcı", CategoryId = 1 },
            ...
        );

        base.OnModelCreating(modelBuilder);
    }
}
```

## Prerequisites

1. **.NET 8-9 SDK**
2. **SQL Server**

## Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/survivor-api.git
   cd survivor-api
   ```

2. Configure the database connection in `appsettings.json`:
   ```json
   "ConnectionStrings": {
       "SqlServer": "Server=localhost,1433;Database=Survivor;User Id=sa;Password=[YOUR_PASSWORD];Encrypt=False;TrustServerCertificate=True"
   }
   ```

3. Restore dependencies:
   ```bash
   dotnet restore
   ```

4. Apply migrations:
   ```bash
   dotnet ef database update
   ```

5. Run the application:
   ```bash
   dotnet run
   ```

## API Endpoints

### Categories Endpoints
- `GET /api/categories`
- `GET /api/categories/{id}`
- `POST /api/categories`
- `PUT /api/categories/{id}`
- `DELETE /api/categories/{id}`

### Competitors Endpoints
- `GET /api/competitors`
- `GET /api/competitors/{id}`
- `GET /api/competitors/categories/{id}`
- `POST /api/competitors`
- `PUT /api/competitors/{id}`
- `DELETE /api/competitors/{id}`