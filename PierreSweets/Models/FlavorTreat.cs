using System.ComponentModel.DataAnnotations;
using System; 

namespace PierreSweets.Models
{
  public class FlavorTreat
  {       
    [Key]
    public int FlavorTreatId { get; set; }
    public int FlavorId { get; set; }
    public int TreatId { get; set; }
    public virtual Flavor Flavor { get; set; }
    public virtual Treat Treat { get; set; }
  }
}