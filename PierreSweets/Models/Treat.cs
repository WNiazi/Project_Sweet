using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreSweets.Models
{
  public class Treat
  {
    public Treat()
    {
      this.FlavorTreatEntities = new HashSet<FlavorTreat>();
    }
    [Key]
    public int TreatId { get; set; }
    public string TreatName { get; set; }
    public virtual ICollection<FlavorTreat> FlavorTreatEntities { get; set; }
  }
}