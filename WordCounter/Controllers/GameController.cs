using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class GameController : Controllers
  {
    [HttpPost("/game")]
    public ActionResult Create(string word, string sentence)
    {
      WordFrequencyCounter newWordFrequencyCounter = new WordFrequencyCounter(word, sentence);
      return RedirectToAction("index")
    }
  }
}
