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
      Console.WriteLine("Your phrase: ");
      string userPhrase = Console.ReadLine();
      RepeatCounter repeatCounter = new RepeatCounter(userWord, userPhrase);
      if (repeatCounter.InputChecker() == false)
      {
        Console.WriteLine("You must write both a word and a phrase.");
        UserQuery();
      }
      int result = repeatCounter.OccurrenceCounter();
      Console.WriteLine(repeatCounter.UserWord + " occurs " + result + " times in your phrase.");
    }
  }

}