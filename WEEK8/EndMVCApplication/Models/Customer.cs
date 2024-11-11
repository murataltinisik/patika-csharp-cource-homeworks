using System.ComponentModel.DataAnnotations;

namespace EndMVCApplication.Models;

public class Customer
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "First Name is required")]
    [StringLength(30, ErrorMessage = "First Name cannot be longer than 30 characters")]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Last Name is required")]
    [StringLength(30, ErrorMessage = "Last Name cannot be longer than 30 characters")]
    public string LastName { get; set; }
    
    [Required(ErrorMessage = "Email is required")]
    [StringLength(70, ErrorMessage = "Email cannot be longer than 70 characters")]
    public string Email { get; set; }
}