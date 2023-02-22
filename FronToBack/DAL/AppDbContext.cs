using Microsoft.EntityFrameworkCore;
using FronToBack.Models;
namespace FronToBack.DAL;
public class AppDbContext : DbContext
{
   
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

         public DbSet<Slider> Sliders{get;set;}
         public DbSet<SliderDetail> SliderDetails {get;set;}
} 