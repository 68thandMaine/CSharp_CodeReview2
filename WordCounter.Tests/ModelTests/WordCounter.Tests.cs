using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordFrequencyCounterTest
  {

    [TestMethod]
    public void Constructor_CreatesInstanceOfWordFrequencyCounter_True()
    {
      WordFrequencyCounter newWord = new WordFrequencyCounter(" ", " ");
      Assert.AreEqual(typeof(WordFrequencyCounter), newWord.GetType());
    }

    [TestMethod]
    public void CompareTwoLetters_ReturnsLetterIfEqual_String()
    {
      string testLetter = "a";
      WordFrequencyCounter newWord = new WordFrequencyCounter("a", " ");
      string result = newWord.CompareTwoLetters();
      Assert.AreEqual(testLetter, result);
    }


  }
}
