using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Dog
  {
    public int DogId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    [StringLength(50)]
    public string Breed { get; set; }
    [Range(0, 50, ErrorMessage = "Age must be between 0 and 50.")]
    public int Age { get; set; }
    [Required]
    [StringLength(1)]
    public string Gender { get; set; }
  }
}