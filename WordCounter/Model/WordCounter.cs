using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class WordFrequencyCounter
  {
    private string _capturedWord;
    private string _capturedSentence;

    public WordFrequencyCounter (string word, string sentence)
    {
      _capturedWord = word;
      _capturedSentence = sentence;
    }
    public string ReturnString()
    {
      string compareString = _capturedWord;
      return compareString;
    }
    public string ReturnSentence()
    {
      string compareSentence = _capturedSentence;
      return compareSentence;
    }
    public string[] SplitSentence()
    {
      string userSentence = _capturedSentence;
      string[] splitArr = userSentence.Split(' ');
      return splitArr;
    }
    public string LetterCounter()
    {
      string wordToBeCounted = _capturedWord;
      string sentenceToBeSplit = _capturedSentence;
      string[] splitArr = sentenceToBeSplit.Split(' ');
      int counter = 0;
      for (int i = 0; i < splitArr.Length; i++)
      if (splitArr[i] == wordToBeCounted)
      {
        counter++;
      }
      string counterCount = counter.ToString();
      return counterCount;
    }
    public int WordCounter()
    {
      string wordToBeCounted = _capturedWord;
      string sentenceToBeSplit = _capturedSentence;
      string[] splitArr = sentenceToBeSplit.Split(' ');
      int counter = 0;
      for (int i = 0; i < splitArr.Length; i++)
      if (splitArr[i] == wordToBeCounted)
      {
        counter++;
      }
      return counter;
    }
  }
}
