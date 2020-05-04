using System;
using System.Collections.Generic;
using EmployeeManagement.Model;

namespace EmployeeManagement.Api.Models
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int departmentId);
    }
}
