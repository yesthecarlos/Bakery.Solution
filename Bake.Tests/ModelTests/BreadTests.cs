using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bake.Models;

namespace Bake.Test
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void GetBreadPrice_ReturnsBreadPrice_Int()
    {
      //Arrange
      string breadCount = "1";
      int breadPrice = 5;
      Bread newBread = new Bread(breadCount, breadPrice);
      
      //Act
      int result = newBread.GetBreadPrice();
      
      //Assert
      Assert.AreEqual(breadPrice, result);
    }
    
  }
}