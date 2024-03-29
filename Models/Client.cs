using System.Collections.Generic;

namespace ECSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Description { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}
