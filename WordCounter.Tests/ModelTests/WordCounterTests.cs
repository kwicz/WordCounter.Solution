using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepeatCounter.Models;
using System;

namespace RepeatCounter.Tests
{
  [TestClass]
  public class Tests
  {
    [TestMethod]
    public void RepeatCounterContructor_InstantiatesNewRepeatCounter_RepeatCouter()
    {
      // Arrange
      string userWord = "world";
      string userPhrase = "Hello world";
      RepeatCounter newCounter = new RepeatCounter(userWord, userPhrase);

      // Assert
      Assert.AreEqual(typeof(RepeatCounter), newCounter.GetType();)
    }

  }
}