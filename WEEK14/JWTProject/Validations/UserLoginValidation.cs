using FluentValidation;
using JWTProject.Models.Contexts;
using JWTProject.Models.DTOs;

namespace JWTProject.Validations;

public class UserLoginValidation : AbstractValidator<UserDto>
{
    // Database Context
    private readonly DatabaseContext _context;
    
    public UserLoginValidation(DatabaseContext context)
    {
        // Context
        _context = context;
        
        RuleFor(user => user.Email)
            .NotEmpty().WithMessage("Email is required")
            .EmailAddress().WithMessage("Invalid email format")
            .Length(12, 120).WithMessage("Email must be between 12 and 120 characters")
            .Must(IsExistsUserByEmail).WithMessage("User Not Found");

        RuleFor(user => user.Password)
            .NotEmpty().WithMessage("Password is required")
            .MinimumLength(6).WithMessage("Password must be at least 6 characters long");
    }
    
    private bool IsExistsUserByEmail(string email)
    {
        return _context.Users.Any(u => u.Email == email);
    }
}