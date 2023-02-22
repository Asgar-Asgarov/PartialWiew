using Microsoft.EntityFrameworkCore;
namespace FronToBack.DAL;
class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
}