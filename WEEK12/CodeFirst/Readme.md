# Code First Application

## Project Structure

```
CodeFirst/
├── Models/
│   ├── Entities
│       ├── Game.cs
│       ├── Movie.cs
│   ├── Contexts
│       ├── PatikaFirstDbContext.cs
├── Program.cs
├── appsettings.json
├── Models/
├── Data/
├── Migrations/
```

## Requirements

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/sql-server)

## Setup

### 1. Clone Project

```bash
cd CodeFirst
```

### 2. Download Dependencies

```bash
dotnet restore
```

### 3. Set Database Connection String

- Edit `ConnectionStrings` in **appsettings.json**.

```json
"ConnectionStrings": {
  "SqlServer": "Server=localhost,1433;Database=PatikaCodeFirstDb1;Trusted_Connection=False;User Id=sa;Password=\"[YOUR_PASSWORD]\";Encrypt=False;"
}
```

### 4. Apply Migrations 

```bash
dotnet ef database update
```

### 5. Run Project

```bash
dotnet run
```