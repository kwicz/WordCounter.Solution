using System;
using WordPhrase.Models;

namespace PhraseSet
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Word Counter!\nEnter a word and a phrase and we will tell you how many times your word occurs in your phrase.");
      UserQuery();
    }

    public static void UserQuery()
    {
      Console.WriteLine("Your word: ");
      string userWord = Console.ReadLine();
      RepeatCounter repeatCounter = new RepeatCounter(userWord);
      string cleanWord = repeatCounter.PunctuationRemover(userWord);
      Console.WriteLine("Your phrase: ");
      string userPhrase = Console.ReadLine();
      string cleanPhrase = repeatCounter.PunctuationRemover(userPhrase);
      RepeatCounter cleanRepeatCounter = new RepeatCounter(cleanWord, cleanPhrase);
      if (cleanRepeatCounter.InputChecker() == false)
      {
        Console.WriteLine("You must write both a word and a phrase.");
        UserQuery();
      }
      int result = cleanRepeatCounter.OccurrenceCounter();
      Console.WriteLine(cleanRepeatCounter.UserWord + " occurs " + result + " times in your phrase.");
    }
    
  }

}