using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using FronToBack.DAL;

namespace FronToBack.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _appDbContext;

    public HomeController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public IActionResult Index()
    { 
        
      return View();
    }

  
   
}
