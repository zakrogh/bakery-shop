using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      int numBread, numPastry;
      Order myOrder = new Order();
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Today we have {0} availabe for ${1} and {2} available for ${3}", Bread.Name, Bread.Price, Pastry.Name, Pastry.Price);
      Console.WriteLine("How many loaves of bread would you like to buy?");
      numBread = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like to buy?");
      numPastry = int.Parse(Console.ReadLine());
    }
  }
}
