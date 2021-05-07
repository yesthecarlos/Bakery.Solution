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

    public int getBreadPrice()
    {
      return _price;
    }
    // public int Count { get; set }
    // private static Int Count _count = new Int Count

  }
}