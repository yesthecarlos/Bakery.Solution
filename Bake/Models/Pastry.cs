using System;

namespace Bake.Models
{
  public class Pastry
  {
    public string PastryTotalCount { get; set; }
    public int PastryUnitPrice { get; set; }
    public int PastryTotalPrice { get; set; }

    public Pastry(string pastryCount)
    {
      PastryTotalCount = pastryCount;
      PastryUnitPrice = 2;
      PastryTotalPrice = 0;
    }

    public int StraightPastryPrice(string pastryCount)
    {
      int intCount = Int32.Parse(pastryCount);
      PastryTotalPrice = intCount * PastryUnitPrice;
      return PastryTotalPrice;
    }

    public int GetPastryPrice(string pastryCount)
    {
      int intCount = Int32.Parse(pastryCount);
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