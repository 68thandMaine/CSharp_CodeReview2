using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class HomeController : Controllers
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      
    }
  }
}
