using System;
using Bake.Models;

namespace Bake.Models
{
  public class Program
  {
    public static void Main()
    {
    Bread pricingBread = new Bread("1");
    Pastry pricingPastry = new Pastry("1");

    Console.WriteLine("Welcome to Pierre's! Bread is currently $"+pricingBread.BreadUnitPrice+" per loaf. Pastries are currently $"+pricingPastry.PastryUnitPrice+" each. Type 'Y' to continue...");

    string userInput = Console.ReadLine();
      string lowerCase = userInput.ToLower();
      if(lowerCase == "y")
      {
        orderForm();
      }
      else
      {
        Main();
      }    
    }
    static void orderForm()
    {
      Console.WriteLine("How many loaves of bread would you like?");
      string breadCount = Console.ReadLine();
      Bread currentBread = new Bread(breadCount);

      Console.WriteLine("How many pastries would you like?");
      string pastryCount = Console.ReadLine();
      Pastry currentPastry = new Pastry(pastryCount);
      
      Console.WriteLine("Your total comes to $" + (currentBread.GetBreadPrice(breadCount) + currentPastry.GetPastryPrice(pastryCount)) + ", thanks! Come back soon!");
    }
  }
}