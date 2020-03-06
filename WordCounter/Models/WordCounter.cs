using System;

namespace WordPhrase.Models
{
  public class RepeatCounter
  {
    public string UserWord { get; set; }
    public string UserPhrase { get; set; }
    public RepeatCounter(string word, string phrase)
    {
      UserWord = word;
      UserPhrase = phrase;
    }
  }

}