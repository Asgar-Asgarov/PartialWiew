using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FronToBack.Models;

namespace FronToBack.Controllers;

public class HomeController : Controller
{


    public IActionResult Index()
    {
        return View();
    }

  
   
}
