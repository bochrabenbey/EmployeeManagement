using EmployeeManagement.Models;

namespace EmployeeManagement.Api.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);
        Task<Employee> UpdateEmployee(Employee employee);
    }
}