using Microsoft.EntityFrameworkCore;

namespace AmitWebAppMVC.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
