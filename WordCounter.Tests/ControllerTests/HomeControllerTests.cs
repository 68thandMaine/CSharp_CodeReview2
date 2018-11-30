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
    public void Index_ReturnsCorrectView_True()
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

    [TestMethod]
    public void Index_HasCorrectModelType_WordFrequencyCounterList()
    {
      //Arrange
      ViewResult indexView = new HomeController().Index() as ViewResult;
      // This will create a new ViewResult called indexView. We are then taking the View of the HomeControllers Index page and casting it as a ViewResult so that we can put data onto the rendered view to the response for compairson.

      //Act
      var result = indexView.ViewData.Model;
      // This creates a vairable named result. By naming it var we allow c# to implicitely decide what type of data result holds. In this case we know that we are holding a rendered view response that has the datatype of the Model in it. I believe this will be a string.

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<WordFrequencyCounter>));
    }
  }
}
