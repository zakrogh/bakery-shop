using System.Collections.Generic;
namespace Bakery.Models
{
  public class Order
  {
    public List<Bread> BreadList { get; set; }
    public List<Pastry> PastryList { get; set; }
    public Order()
    {
      BreadList = new List<Bread>();
      PastryList = new List<Pastry>();
    }
    public void AddBread(int amount)
    {
      for(int i = 0; i < amount; i++)
      {
        Bread bread = new Bread();
        BreadList.Add(bread);
      }
    }
    public void AddPastry(int amount)
    {
      for(int i = 0; i < amount; i++)
      {
        Pastry pastry = new Pastry();
        PastryList.Add(pastry);
      }
    }
    public int CalculateTotal()
    {
      int breadTotal = 0,
          pastryTotal = 0;
      for(int i = 0; i < BreadList.Count; i++)
      {
        if((i + 1) % 3 != 0)
          breadTotal += BreadList[i].Price;
      }
      for(int i = 0; i < PastryList.Count; i++)
      {
        if((i + 1) % 3 != 0)
          pastryTotal += PastryList[i].Price;
        else
          pastryTotal += PastryList[i].Price / 2;
      }
      return (breadTotal + pastryTotal);
    }
  }
}
