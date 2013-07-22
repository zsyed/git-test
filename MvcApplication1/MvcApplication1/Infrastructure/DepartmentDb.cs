using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eManager.Domain;

namespace MvcApplication1.Infrastructure
{
    public class DepartmentDb : DbContext, IDepartmentDataSource
    {
        public DepartmentDb(): base("DefaultConnection")
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        IQueryable<Employee> IDepartmentDataSource.Employees
        {
            get { return Employees; }
        }

        IQueryable<Department> IDepartmentDataSource.Departments
        {
            get { return Departments; }
        }
    }
}