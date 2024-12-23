# JWT Project

This is a .NET 9 Web API project implementing JWT-based authentication and authorization. It provides user registration and login functionalities, with proper validations and secure password handling using `IDataProtector`.

## Features

- **Authentication & Authorization:** Secure JWT-based token generation and validation.
- **Password Protection:** Utilizes `IDataProtector` for encrypting and decrypting user passwords.
- **Validation:** Employs `FluentValidation` for input validation.
- **Database Integration:** Supports SQL Server as the backend database with Entity Framework Core.
- **Swagger Documentation:** Integrated Swagger UI for testing the API endpoints.

## Project Structure

```
JWTProject
├── Controllers
│   └── Auth
│       └── AuthController.cs
├── Helpers
│   └── JwtHelper.cs
├── Migrations
├── Models
│   ├── Contexts
│   │   └── DatabaseContext.cs
│   ├── DTOs
│   │   └── UserDto.cs
│   ├── Entities
│       └── User.cs
├── Validations
│   ├── UserLoginValidation.cs
│   └── UserRegisterValidator.cs
├── appsettings.json
├── appsettings.Development.json
├── Program.cs
└── JWTProject.http
```

## Getting Started

### Installation

1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd JWTProject
   ```
2. Restore the NuGet packages:
   ```bash
   dotnet restore
   ```
3. Update the `appsettings.json` file with your database connection string and JWT settings:
   ```json
   {
     "ConnectionStrings": {
       "SqlServer": "Server=localhost,1433;Database=JwtApplicationDb;User Id=sa;Password=[YOUR_PASSWORD];TrustServerCertificate=True;"
     },
     "JwtSettings": {
       "Issuer": "yourapp.com",
       "Audience": "yourapp.com",
       "Key": "this_is_a_very_strong_secret_key_1234567890",
       "ExpiresInMinutes": 60
     }
   }
   ```

4. Apply database migrations:
   ```bash
   dotnet ef database update
   ```

5. Run the application:
   ```bash
   dotnet run
   ```

### Endpoints

#### **Authentication**

1. **Login**
    - Endpoint: `POST /auth/login`
    - Request Body:
      ```json
      {
        "email": "user@example.com",
        "password": "password123"
      }
      ```
    - Response:
      ```json
      {
        "message": "Login successfully!",
        "token": "<jwt-token>"
      }
      ```

2. **Register**
    - Endpoint: `POST /auth/register`
    - Request Body:
      ```json
      {
        "email": "user@example.com",
        "password": "password123"
      }
      ```
    - Response:
      ```json
      {
        "message": "User registered successfully!",
        "token": "<jwt-token>"
      }
      ```

### Middleware Configuration

- **Authentication & Authorization**
  Ensure these middlewares are configured in `Program.cs`:
  ```csharp
  app.UseAuthentication();
  app.UseAuthorization();
  ```
