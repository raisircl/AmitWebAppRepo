namespace AmitWebAppMVC.Models
{
    public class EmployeeMysqlRepo : IEmployeeRepository
    {
        private readonly AppDBContext context;

        public EmployeeMysqlRepo(AppDBContext context)
        {
            this.context = context; // DI
        }
        public Employee Add(Employee employee)
        {
            context.Employees.Add(employee);    
            context.SaveChanges();
            return employee;
        }

        public Employee Delete(int Id)
        {
            Employee employee = context.Employees.Find(Id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
            return employee;

        }

        public List<Employee> GetAllEmployees()
        {
            return context.Employees.ToList();
        }

        public Employee GetEmployee(int Id)
        {
            return context.Employees.FirstOrDefault(x => x.Id == Id);
        }

        public Employee Update(Employee employeeChanges)
        {
            var employee = context.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return employeeChanges;

        }

    }
}
