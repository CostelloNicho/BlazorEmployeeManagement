using System;
using EmployeeManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Employee> Emloyees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "Stark"}
                );
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "Lannister" }
                );

            //Seed Employee Table
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "John",
                    LastName = "Snow",
                    Email = "JSnow@gmail.com",
                    DateOfBirth = new DateTime(1989,3,10),
                    Gender = Gender.Male,
                    DepartmentId = 0,
                    PhotoPath = ""
                 }
             );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Jamie",
                    LastName = "Lannister",
                    Email = "PVPMeBro@gmail.com",
                    DateOfBirth = new DateTime(1980, 3, 10),
                    Gender = Gender.Male,
                    DepartmentId = 1,
                    PhotoPath = ""
                }
             );

        }
    }
}
