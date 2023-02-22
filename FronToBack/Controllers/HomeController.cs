using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FronToBack.Models;
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
        
        List<Student> students = _appDbContext.Students.ToList();
        return View(students);
    }

  
   
}
