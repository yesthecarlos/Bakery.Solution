using System;

namespace Bake.Models
{
  public class Bread
  {
    public int Count { get; set };
    private static int _price = new int{}; 
    
    public BreadPrice(int count)
    {
      Count = count;

    }

  }
}