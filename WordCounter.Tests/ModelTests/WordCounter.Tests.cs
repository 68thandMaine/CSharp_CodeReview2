using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordFrequencyCounterTest
  {
    [TestMethod]
    public void constructor_CreatesInstanceOfWordFrequencyCounter_True()
    {
      WordFrequencyCounter newWord = new WordFrequencyCounter();
      Assert.AreEqual(typeof(WordFrequencyCounter), newWord.GetType());
    }
    
  }
}
