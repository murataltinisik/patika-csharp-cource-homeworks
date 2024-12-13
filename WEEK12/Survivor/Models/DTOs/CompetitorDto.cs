using System.ComponentModel.DataAnnotations;

namespace Survivor.Models.DTOs;

public class CompetitorDto
{
    public int Id { get; set; }

    [Required]
    public int CategoryId { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters.")]
    public string? FirstName { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters.")]
    public string? LastName { get; set; }
}