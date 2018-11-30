using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      //FAILING TEST METHOD
      //To fail the test that determins if this route returns the corrected DataType we will return something that is still an ActionResult, but is not a ViewResult. This will compile because all ViewResults are ActionResults, but not all ActionResults are ViewResults. There are many different classes within the ActionResult class.

      // return new EmptyResult();

      // An EmptyResult is a type of ActionResult that does not share the same properties as a ViewResult. Thus the return of the ActoinResult is still valid,  but it will fail the Assert test because an EmptyResult is not a ViewResult.

      //PASSING TEST METHOD

      return View();

      // Returning a View will pass becasue the assert statment will determine a View is a ViewResult.
    }

  }
}
