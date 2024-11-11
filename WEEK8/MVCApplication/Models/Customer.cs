
using System.ComponentModel.DataAnnotations;

namespace MVCApplication.Models;

public class Customer
{
    public int Id { get; set; }
    [Required(ErrorMessage = "First Name is required")]
    [StringLength(30)]
    public required string FirstName { get; set; }
    
    [Required(ErrorMessage = "Last Name is required")]
    [StringLength(30)]
    public required string LastName { get; set; }
    
    [Required(ErrorMessage = "Email is required")]
    [StringLength(70)]
    public required string Email { get; set; }
}