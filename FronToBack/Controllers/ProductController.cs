using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FronToBack.Models;
using FronToBack.DAL;
using FronToBack.ViewModel;
namespace FronToBack.Controllers;


public class ProductController : Controller
{

private readonly AppDbContext _appDbContext;

    public ProductController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public IActionResult Index()
    {
        return View();
    }

}