using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("This application will count the number of times a word is in a sentence!");
      Console.WriteLine("Please enter a word that you wish to count:");
      string userWord = Console.ReadLine();
      Console.WriteLine("Please enter any sentence:");
      string userSentence = Console.ReadLine();
      WordFrequencyCounter myWordFrequencyCounter = new WordFrequencyCounter(userWord, userSentence);
      int result = myWordFrequencyCounter.WordCounter();
      Console.WriteLine("______________________________________________________");
      Console.WriteLine(" ");
      Console.WriteLine("In the sentence " +  userSentence  + " the word " + userWord + " appears " + result + " times.");
      Console.WriteLine("______________________________________________________");
      Console.WriteLine(" ");
      Console.WriteLine("Are you finished with this program? ['Y' for yes, 'Enter' if you wish to try another word sentence combination]");
      string finishedAnswer = Console.ReadLine();
      if (finishedAnswer == "Y" || finishedAnswer == "y")
      {
        Console.WriteLine("Goodbye.");
      }
      else
      {
        Main();
      }
    }
  }
}
