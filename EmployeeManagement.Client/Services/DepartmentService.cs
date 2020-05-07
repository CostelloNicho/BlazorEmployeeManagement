using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using EmployeeManagement.Model;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Client.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly HttpClient _httpClient;

        public DepartmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Department> GetDepartment(int departmentId)
        {
            return await _httpClient.GetJsonAsync<Department>($"api/departments/{departmentId}");
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _httpClient.GetJsonAsync<Department[]>($"api/departments");
        }
    }
}
