using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System.Collections.Generic;

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
    public void ReturnString_ReturnsAString_String()
    {
      string testLetter = "a";
      WordFrequencyCounter newTest = new WordFrequencyCounter("a", " ");
      string result = newTest.ReturnString();
      Assert.AreEqual(testLetter, result);
    }

    [TestMethod]
    public void ReturnSentence_ReturnASentence_String()
    {
      string testSentence = "Wow, what a task this is";
      WordFrequencyCounter newTest = new WordFrequencyCounter("a", "Wow, what a task this is");
      string result = newTest.ReturnSentence();
      Assert.AreEqual(testSentence, result);
    }

    [TestMethod]
    public void SplitSentence_ReturnAListOfWordsInSentence_String()
    {
      string[] testArray = new string[] {"Hey", "now", "hey", "now"};
      WordFrequencyCounter newTest = new WordFrequencyCounter("a", "Hey now hey now");
      string[] result = newTest.SplitSentence();
      CollectionAssert.AreEqual(testArray, result);
    }

    [TestMethod]
    public void LetterCounter_CountAllInstancesOfASingleLetterInASentence_String()
    {
      string expectedAnswer = "2";
      WordFrequencyCounter newTest = new WordFrequencyCounter ("a", "Look at a word that a user can enter");
      string result = newTest.LetterCounter();
      Assert.AreEqual(expectedAnswer, result);
    }
  }
}
