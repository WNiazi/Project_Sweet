using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreSweets.Models
{
  public class Flavor
  {
    [Key]
    public int FlavorId { get; set; }

    [Required(ErrorMessage = "Please enter flavor name")]
    public string FlavorName { get; set; }
  }
}