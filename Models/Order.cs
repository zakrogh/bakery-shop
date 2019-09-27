namespace Bakery.Models
{
  public class Order
  {
    public List<Bread> BreadList { get; set; } = new List<Bread>();
    public List<Pastry> PastryList { get; set; } = new List<Pastry>();
    public Order()
    {

    }
    public int CalculateTotal()
    {
      
    }
  }
}
