using System.ComponentModel.DataAnnotations;

namespace IdentityDataProtection.Models.Entities;

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