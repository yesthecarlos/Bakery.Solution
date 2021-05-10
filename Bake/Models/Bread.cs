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
      ;
      bool breadBool = intCount % 3 == 0;
      int breadPrice;
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
    // public int Count { get; set }
    // private static Int Count _count = new Int Count

  }
}