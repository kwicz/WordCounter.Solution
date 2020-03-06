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
    public void OccurrenceCounter_CountNumberOfWordOccurences_Int()
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

    [TestMethod]
    public void OccurrenceCounter_EnsurePartialMatchesArentCounted_Int()
    {
      // Arrange
      string userWord = "cat";
      string userPhrase = "My cat is going to the cathedral.";
      RepeatCounter newCounter = new RepeatCounter(userWord, userPhrase);
      
      // Act
      int occurrences = newCounter.OccurrenceCounter();
      
      // Assert
      Assert.AreEqual(1, occurrences);
    }

    [TestMethod]
    public void PunctuationRemover_AccountForPunctuation_String()
    {
      // Arrange
      string userWord = "cat";
      string userPhrase = "My cat, my other cat, and my dog went to the cathedral.";
      RepeatCounter newCounter = new RepeatCounter(userWord, userPhrase);
      
      // Act
      string noPunct = newCounter.PunctuationRemover(userPhrase);

      // Assert
      Assert.AreEqual("My cat  my other cat  and my dog went to the cathedral ", noPunct);
    }
  }
}