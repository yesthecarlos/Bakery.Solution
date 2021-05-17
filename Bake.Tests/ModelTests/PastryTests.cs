using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bake.Models;

namespace Bake.Test
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry("1");

      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void StraightPastryPrice_ReturnsUndiscountedPastryPrice_Int()
    {
      string pastryCount = "3";
      int pastryPrice = 6;
      Pastry newPastry = new Pastry(pastryCount);

      int result = newPastry.StraightPastryPrice(pastryCount);
      
      Assert.AreEqual(pastryPrice, result);
    }
    [TestMethod]
    public void GetPastryPrice_ReturnsDiscountedPastryPrice_Int()
    {
      string pastryCount = "4";
      int pastryPrice = 7;
      Pastry newPastry = new Pastry(pastryCount);
      
      int result = newPastry.GetPastryPrice(pastryCount);
      
      Assert.AreEqual(pastryPrice, result);
    }
  }
}