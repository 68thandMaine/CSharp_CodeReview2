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
    }
  }
