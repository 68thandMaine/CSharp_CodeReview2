using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Controllers;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void
    Index_ReturnsCorrectView_True()
    {
      //Arrange
      HomeController controller = new HomeController();
      //This will instantiate a new HomeController class to allow methods to be tested on the controller.

      //Act
      ActionResult indexView = controller.Index();
      //This will create an ActionResult datatype called indexView that holds the result of calling the Index method on the HomeController named controller. Index returns a view of the Views file in the Home folder named Index.cshtml

      //Asert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      //This will assert that the result of index view will be of the same datatype of a ViewResult.

    }
  }
}
