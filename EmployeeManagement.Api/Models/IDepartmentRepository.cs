using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.Model;

namespace EmployeeManagement.Api.Models
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int departmentId);
    }
}
