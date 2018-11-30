using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;


namespace WordCounter.Controllers
{
  public class GameController : Controller
  {
    [HttpGet("/game")]
    public ActionResult Index()
    {
      return View();
    }


    [HttpPost("/game/new")]
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
  }
}
