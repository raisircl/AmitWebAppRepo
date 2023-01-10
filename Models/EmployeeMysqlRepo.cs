namespace AmitWebAppMVC.Models
{
    public class EmployeeMysqlRepo : IEmployeeRepository
    {
        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int Id)
        {
           return new Employee{Id=1001,Name="Ram from Mysql",Email="ram@mysql.com", Department="My SQL DB" };
        }
    }
}
