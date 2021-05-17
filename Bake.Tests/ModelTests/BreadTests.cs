using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bake.Models;

namespace Bake.Test
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("1");
      
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void StraightBreadPrice_ReturnsUndiscountedBreadPrice_Int()
    {
      string breadCount = "3";
      int breadPrice = 15;
      Bread newBread = new Bread(breadCount);

      int result = newBread.StraightBreadPrice(breadCount);
      
      Assert.AreEqual(breadPrice, result);
    }
    [TestMethod]
    public void GetBreadPrice_ReturnsDiscountedBreadPrice_Int()
    {
      int breadPrice = 40;
      string breadCount = "12";
      Bread newBread = new Bread(breadCount);

      int result = newBread.GetBreadPrice(breadCount);
    
      Assert.AreEqual(breadPrice, result);
    }
  }
}