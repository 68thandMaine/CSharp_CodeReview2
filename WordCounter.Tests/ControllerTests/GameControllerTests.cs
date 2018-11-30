using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Controllers;
using WordCounter.Models;
using System;


namespace WordCounter.Tests
{
  [TestClass]
  public class GameControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      GameController controller = new GameController();

      //Act
      ActionResult indexView = controller.Index();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }




    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
      //Arrange
      GameController controller = new GameController();
      // This will instantiate a new instance of a Game controller that we call Controller.

      //Act
      var view = controller.Create("cars", "cars drive down the road");
      //Because the first page of the app takes two arguments in and returns them as a type of ActionResult, we are calling this variable view.

      //Assert
      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
      //Here we assert that the variable view holds the data type RedirectToActionResult.
    }
    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
      //Arrange
      GameController controller = new GameController();
      RedirectToActionResult actionResult = controller.Create("chairs","Look at all these chairs here! I've never sat in so many plush chairs") as RedirectToActionResult;
      //This will create a new GameController called controller. I then call the create Create() method on controller and pass in two strings and then cast controller from a GameController type to a RedirectToActionResult type.

      //Act
      string result = actionResult.ActionName;
      //This will store the value that is passed into the RedirectToAction method that Create returns. It is passed a string as a paramater so result is set to a string.

      //Assert
      Assert.AreEqual(result, "Index");
      //I assert that the string that the create method returns is equal to the string "index"
    }
  }
}
