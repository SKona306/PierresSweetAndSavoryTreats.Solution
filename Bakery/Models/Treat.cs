using System.Collections.Generic;

namespace Bakery.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<Flavor_Treat>();
    }

    public int TreatId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual ICollection<Flavor_Treat> JoinEntities { get; set; }
  }
}