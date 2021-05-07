using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bake.Models;

namespace Bake.Test
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_int()
    {
    //Arrange
    int breadCount = 1;
    int pastryCount = 1;
    //Act
    int result = Bread.Count;
    //Assert
    Assert.AreEqual(count, result);
    }
    
  }
}