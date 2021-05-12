using System;

namespace Bake.Models
{
  public class Pastry
  {
    private string _count;
    private int _price;

    public Pastry(string pastryCount, int pastryPrice)
    {
      _count = pastryCount;
      _price = pastryPrice;
    }

    public int GetPastryPrice(string pastryCount)
    {
      int intCount = Int32.Parse(pastryCount);
      ;
      bool pastryBool = intCount % 3 == 0;
      int pastryPrice;
      if (intCount >= 3) 
      {
        if (pastryBool)
        {
          pastryPrice = ((intCount*2)) - ((intCount*2)/6);
        }
        else 
        {
        pastryPrice = ((intCount * 2) - (int)Math.Ceiling((decimal)intCount/6));
        }
      }
      else 
      {
        pastryPrice = intCount*2;
      }
      return pastryPrice;
    }
  }
}