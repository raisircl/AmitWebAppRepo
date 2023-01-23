using Microsoft.EntityFrameworkCore;

namespace AmitWebAppMVC.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee()
            {
                Id = 1,
                Name = "Amit",
                Email = "amit.sircltech@.com",
                Department = Department.SW,
                Job = "Programmer",
                Salary = 50000,
                HireDate = DateTime.Now

            });
        }
    }
}
