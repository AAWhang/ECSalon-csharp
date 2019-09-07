namespace ECSalon.Models
{
  public class StylistClients
    {
        public int StylistClientsId { get; set; }
        public int StylistId { get; set; }
        public int ClientId { get; set; }
        public virtual Stylist Stylist { get; set; }
        public virtual Client Client { get; set; }
    }
}
