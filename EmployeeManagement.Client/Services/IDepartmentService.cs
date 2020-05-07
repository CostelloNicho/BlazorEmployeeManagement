using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.Model;

namespace EmployeeManagement.Client.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int departmentId);
    }
}
