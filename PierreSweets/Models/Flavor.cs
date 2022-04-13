using System.Collections.Generic;

namespace PierreSweets.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.FlavorTreatEntities = new HashSet<FlavorTreat>();
    }
    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<FlavorTreat> FlavorTreatEntities { get;}
  }
}