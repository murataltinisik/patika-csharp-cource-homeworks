using System.ComponentModel.DataAnnotations;

namespace EndMVCApplication.Models;

public class Order
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Please enter your product name")]
    [StringLength(100, ErrorMessage = "Product name must be between 3 and 100 characters")]
    public string ProductName { get; set; }
    
    [Required(ErrorMessage = "Please enter your product price")]
    [Range(1, 10000, ErrorMessage = "Product price must be between 1 and 10000")]
    public decimal Price { get; set; }
    
    [Required(ErrorMessage = "Please enter your product quantity")]
    [Range(1, 100, ErrorMessage = "Product quantity must be between 1 and 100")]
    public int Quantity { get; set; }
}