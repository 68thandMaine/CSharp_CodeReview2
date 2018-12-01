using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class WordFrequencyCounter
  {
    private string _capturedWord;
    private string _capturedSentence;
    private static List<WordFrequencyCounter> _games = new List<WordFrequencyCounter> {};


    public WordFrequencyCounter (string word, string sentence)
    {
      _capturedWord = word;
      _capturedSentence = sentence;
      _games.Add(this);

    }

    public static List<WordFrequencyCounter> GetGame()
    {
      return _games;
    }

    public int WordCounter()
    {
      string wordToBeCounted = _capturedWord.ToLower();
      string sentenceToBeSplit = _capturedSentence.ToLower();
      char[] splitRules = {' ',',','.','!','?'};
      string[] splitArr = sentenceToBeSplit.Split(splitRules);
      int counter = 0;
      for (int i = 0; i < splitArr.Length; i++)
      if (splitArr[i] == wordToBeCounted)
      {
        counter++;
      }
      return counter;
    }
    public string GetWord()
    {
      return _capturedWord;
    }
    public string GetText()
    {
      return _capturedSentence;
    }
    public static void ClearAll()
    {
      _games.Clear();
    }
  }
}
