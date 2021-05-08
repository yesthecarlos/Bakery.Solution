using System;

namespace Bake.Models
{
  public class Bread
  {
    private string _count;
    private int _price;

    public Bread(string breadCount, int breadPrice)
    {
      _count = breadCount;
      _price = breadPrice;
    }

    public int GetBreadPrice(string breadCount)
    {
      int intCount = Int32.Parse(breadCount);
      Console.WriteLine(intCount);
      bool breadBool = MultipleOf(intCount)
        {
          return (intCount % 3) == 0;
        };
      if (intCount >= 2) 
      {
        if (breadBool)
        {
          int breadPrice = (intCount * 5)-((intCount*5)*(1/3));
        }
      }
      else 
      {
        int breadPrice = intCount*5;
      }
      return breadPrice;
    }
    // public int Count { get; set }
    // private static Int Count _count = new Int Count

  }
}