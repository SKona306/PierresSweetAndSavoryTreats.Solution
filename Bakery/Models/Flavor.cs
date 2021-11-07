using System.Collections.Generic;

namespace Bakery.Models 
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<Flavor_Treat>();
    }

    public int FlavorId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<Flavor_Treat> JoinEntities { get; set; }
  }
}