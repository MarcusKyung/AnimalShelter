using Microsoft.AspNetCore.Mvc;
// using ToDoList.Models;
// using System.Colletions.Generic;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}