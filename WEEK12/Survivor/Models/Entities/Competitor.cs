using System.ComponentModel.DataAnnotations;

namespace Survivor.Models.Entities;

public class Competitor
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    
    public Category Category { get; set; }
}