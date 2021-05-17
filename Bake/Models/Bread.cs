using System;

namespace Bake.Models
{
  public class Bread
  {
    public string BreadTotalCount { get; set; }
    public int BreadUnitPrice { get; set; }
    public int BreadTotalPrice { get; set; }

    public Bread(string breadCount)
    {
      BreadTotalCount = breadCount;
      BreadUnitPrice = 5;
      BreadTotalPrice = 0;
    }

    public int StraightBreadPrice(string breadCount)
    {
      int intCount = Int32.Parse(breadCount);
      BreadTotalPrice = intCount * BreadUnitPrice;
      return BreadTotalPrice;
    }

    public int GetBreadPrice(string breadCount)
    {
      int intCount = Int32.Parse(breadCount);
      bool breadBool = intCount % 3 == 0;
      int breadPrice = BreadTotalPrice;
      if (intCount >= 2) 
      {
        if (breadBool)
        {
          breadPrice = ((intCount*5)) - ((intCount*5)/3);
        }
        else 
        {
        breadPrice = ((intCount-(int)(intCount/3))*5);
        }
      }
      else 
      {
        breadPrice = intCount*5;
      }
      return breadPrice;
    }
  }
}