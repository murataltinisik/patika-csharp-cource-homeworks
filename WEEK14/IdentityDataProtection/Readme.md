# Identity Data Protection API

This project demonstrates a basic ASP.NET Core Web API that incorporates **Data Protection** for securely encrypting sensitive user data, such as passwords.

---

## Project Structure

```
IdentityDataProtection
├── Controllers
│   └── UsersController.cs
├── Migrations
├── Models
│   ├── Context
│   │   └── DatabaseContext.cs
│   ├── Entities
│   │   └── User.cs
├── appsettings.json
├── appsettings.Development.json
├── IdentityDataProtection.http
├── Program.cs
└── wwwroot
```

---

## Features

- **Data Protection**: Uses ASP.NET Core's Data Protection API to securely encrypt user passwords.
- **Validation**: Implements strong validation rules for email and password fields.
- **Swagger Integration**: Automatically generates API documentation for testing and exploring endpoints.
- **Entity Framework Core**: Manages database operations efficiently.

---

## Endpoints

### Save a User
- **Endpoint**: `POST /Users`
- **Request Body**:
  ```json
  {
    "email": "test@example.com",
    "password": "123456"
  }
  ```
- **Response**:
  ```json
  {
    "message": "User added successfully!",
    "user": {
      "id": 1,
      "email": "test@example.com",
      "password": "EncryptedPassword"
    }
  }
  ```
---

## How to Run

### Steps

1. **Clone the Repository**
   ```bash
   git clone <repository-url>
   cd IdentityDataProtection
   ```

2. **Set Up the Database**
    - Update the connection string in `appsettings.json`:
      ```json
      "ConnectionStrings": {
          "SqlServer": "Server=localhost,1433;Database=IdentityDataProtection;User Id=Sa;Password=[YOUR_PASSWORD];TrustServerCertificate=True;"
      }
      ```
    - Apply the database migrations:
      ```bash
      dotnet ef migrations add InitialCreate
      dotnet ef database update
      ```

3. **Run the Application**
   ```bash
   dotnet run
   ```

4. **Test the API**
    - Use Swagger UI:
      ```
      http://localhost:5000/swagger
      ```
---

## Code Highlights

### 1. UsersController

Handles user management, including saving users with encrypted passwords.

```csharp
[HttpPost]
public IActionResult Save(User user)
{
    if (!ModelState.IsValid)
    {
        var error = ModelState.Values
            .SelectMany(v => v.Errors)
            .Select(e => e.ErrorMessage);
        return BadRequest(error);
    }
    
    user.Password = _dataProtector.Protect(user.Password);
    _context.Users.Add(user);
    _context.SaveChanges();
    return Ok(new { Message = "User added successfully!", User = user });
}
```

### 2. DatabaseContext

Defines the database structure for the `Users` table.

```csharp
public class DatabaseContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}
}
```

### 3. User Entity

Includes validation for email and password.

```csharp
public class User
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    [StringLength(120, ErrorMessage = "Email must be between 12 and 120 characters", MinimumLength = 12)]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Password is required")]
    [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
    public string Password { get; set; }
}
```

### 4. Program.cs

Configures services for the database, data protection, and Swagger.

```csharp
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"))
);

builder.Services.AddDataProtection().SetApplicationName("IdentityDataProtection");
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
```
