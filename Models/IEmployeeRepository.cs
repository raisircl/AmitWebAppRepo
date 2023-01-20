namespace AmitWebAppMVC.Models
{
    public interface IEmployeeRepository
    {
         List<Employee> GetAllEmployees();
         Employee Add(Employee employee);    
        Employee GetEmployee(int Id);
        Employee Update(Employee employeeChanges);
        Employee Delete(int Id);

    }
}
