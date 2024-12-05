using System.ComponentModel.DataAnnotations;

namespace CrazyMusicians.models;

public class Musician
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "You must enter a name")]
    [StringLength(50, ErrorMessage = "The name must not exceed 50 characters")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "You must enter a job")]
    [StringLength(50, ErrorMessage = "The job must not exceed 50 characters")]
    public string? Job { get; set; }

    [Required(ErrorMessage = "You must enter a fun feature")]
    [StringLength(200, ErrorMessage = "The fun feature must not exceed 200 characters")]
    public string? FunFeature { get; set; }
}