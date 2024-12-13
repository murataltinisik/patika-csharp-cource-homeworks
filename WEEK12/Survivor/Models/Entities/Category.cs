using System.ComponentModel.DataAnnotations;

namespace Survivor.Models.Entities;

public class Category
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}