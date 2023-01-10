namespace AmitWebAppMVC.Models
{
    public interface IEmployeeRepository
    {
         List<Employee> GetAllEmployees();
        Employee GetEmployee(int Id);
    }
}
