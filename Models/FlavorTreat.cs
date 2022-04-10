using System.ComponentModel.DataAnnotations;
using System; 
using System.Collections.Generic; 

namespace PierreSweets.Models
{
  public class FlavorTreat
  {       
    public FlavorTreat()
    {
      this.FlavorTreatEntities = new HashSet<FlavorTreat>();
    }
   
    public int FlavorTreatId { get; set; }
    public int FlavorId { get; set; }
    public int TreatId { get; set; }
    public virtual Flavor Flavor { get; set; }
    public virtual Treat Treat { get; set; } 
    public virtual ICollection<FlavorTreat> FlavorTreatEntities { get; set; }
  }
}