using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPhrase.Models;
using System;

namespace WordPhrase.Tests
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
      Assert.AreEqual(typeof(DateTime), newCounter.GetType());
    }

  }
}