using Microsoft.EntityFrameworkCore;

namespace CrudWithImages_DotNetCoreMVC.Models
{
    public class MyAppContext : DbContext
    {
        public MyAppContext()
        {

        }

        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options)
        {

        }

        public DbSet<Laptop> Laptops { get; set; } = null!;
    }
}
