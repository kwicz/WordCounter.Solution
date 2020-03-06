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
      Assert.AreEqual(typeof(RepeatCounter), newCounter.GetType());
    }

    [TestMethod]
    public void InputChecker_ChecksForCorrectUserUnput_True()
    {
      // Arrange
      string userWord = "world";
      string userPhrase = "Hello world";
      RepeatCounter newCounter = new RepeatCounter(userWord, userPhrase);
      
      // Act
      bool correctInput = newCounter.InputChecker();
      
      // Assert
      Assert.AreEqual(true, correctInput);
    }

    [TestMethod]
    public void OccurrenceCounter_CountAmountOfWordOccurances_Int()
    {
      // Arrange
      string userWord = "world";
      string userPhrase = "Hello world";
      RepeatCounter newCounter = new RepeatCounter(userWord, userPhrase);
      
      // Act
      int occurrences = newCounter.OccurrenceCounter();
      
      // Assert
      Assert.AreEqual(1, occurrences);
    }

  }
}