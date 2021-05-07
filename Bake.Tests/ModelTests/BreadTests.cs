using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bake.Models;

namespace Bake.Test
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void GetBreadCount_ReturnsBreadCount_int()
    {
    //Arrange
    int count = 3;
    //Act
    int result = Bread.Count;
    //Assert
    Assert.AreEqual(count, result);
    }
    
  }
}