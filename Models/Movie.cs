
using System.ComponentModel.DataAnnotations;

namespace Clase04b.Models;

public class Movie{
    public string Code { get; set; }

    [Display(Name="Nombre")]
    [Required]
    public string Name { get; set; }
    [Range(20,700)]
    public int Minutes { get; set; }
    public string Category { get; set; }
    public string Review { get; set; }
}