using Microsoft.EntityFrameworkCore;

namespace FronToBack.DAL;
public class AppDbContext : DbContext
{
   
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

        // public DbSet<Student> Students{get;set;}
} 