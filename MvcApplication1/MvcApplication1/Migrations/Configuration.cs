namespace MvcApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using eManager.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcApplication1.Infrastructure.DepartmentDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MvcApplication1.Infrastructure.DepartmentDb context)
        {
            context.Departments.AddOrUpdate(d => d.Name,
                new Department() { Name = "Engineering" },
                new Department() { Name = "Sales" },
                new Department() { Name = "Shipping" },
                new Department() { Name = "Human Resource" }
                );
        }
    }
}
