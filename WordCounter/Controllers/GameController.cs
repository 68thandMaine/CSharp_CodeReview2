using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class GameController : Controller
  {
    [HttpGet("/game/new")]
    public ActionResult New()
    {
      WordFrequencyCounter.ClearAll();
      return View();
    }

    [HttpPost("/game")]
    public ActionResult Create(string word, string sentence)
    {
      //TO FAIL---------------
      //To fail this test returning correct action type we need to return a type of ActionResult that is not a RedirectToActionResult
      // WordFrequencyCounter newWordFrequencyCounter = new WordFrequencyCounter(word, sentence);

      // return new EmptyResult();

      //TO PASS----------------
      WordFrequencyCounter newWordFrequencyCounter = new WordFrequencyCounter(word, sentence);
      return RedirectToAction("Index");
    }

    [HttpGet("/game")]
    public ActionResult Index()
    {
      List<WordFrequencyCounter> game = WordFrequencyCounter.GetGame();
      return View(game);
    }

    // [HttpPost("/game/delete")]
    // public ActionResult Delete()
    // {
    //   WordCounter.ClearAll();
    //   return View();
    // }
  }
}
