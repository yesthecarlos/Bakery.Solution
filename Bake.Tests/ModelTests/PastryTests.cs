using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bake.Models;

namespace Bake.Test
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void GetPastryPrice_ReturnsPastryPrice_Int()
    {
      //Arrange
      string pastryCount = "4";
      int pastryPrice = 7;
      Pastry newPastry = new Pastry(pastryCount, pastryPrice);
      
      //Act
      int result = newPastry.GetPastryPrice(pastryCount);
      
      //Assert
      Assert.AreEqual(pastryPrice, result);
    }
    
  }
}