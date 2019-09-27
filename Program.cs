using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      int numBread, numPastry, grandTotal;
      Order myOrder = new Order();
      Console.WriteLine("-------------------------------------------");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Today we have Bread availabe for $5 and Pastry available for $3");
      Console.WriteLine("There is also a sale running: every third loaf of bread is free, and every third pastry is half off.");
      Console.WriteLine("-------------------------------------------");
      Console.WriteLine("How many loaves of bread would you like to buy?");
      numBread = int.Parse(Console.ReadLine());
      myOrder.AddBread(numBread);
      Console.WriteLine("How many pastries would you like to buy?");
      numPastry = int.Parse(Console.ReadLine());
      myOrder.AddPastry(numPastry);
      grandTotal = myOrder.CalculateTotal();
      Console.WriteLine("Your total is ${0}, thank you for shopping at Pierre's Bakery!", grandTotal);
    }
  }
}
