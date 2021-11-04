namespace Bakery.Models
{
  public class Flavor_Treat
  {
    public int Flavor_TreatId { get; set; }
    public int FlavorId { get; set; }
    public int TreatId { get; set; }
    public virtual Flavor Flavor { get; set; }
    public virtual Treat Treat { get; set; }
  }
}