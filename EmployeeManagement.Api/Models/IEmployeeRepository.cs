using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.Model;

namespace EmployeeManagement.Api.Models
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<Employee> DeleteEmployee(int employeeID);
        Task<IEnumerable<Employee>> Search(string name, Gender? gender);
    }
}
