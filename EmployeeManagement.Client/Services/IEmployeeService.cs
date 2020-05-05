﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.Model;

namespace EmployeeManagement.Client.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
    }

}