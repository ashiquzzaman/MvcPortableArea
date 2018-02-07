using AzR.Core.Models;
using AzR.Core.Repositories;
using System.Data.Entity.Migrations;
namespace AzR.Core.Migrations
{


    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            context.Employees.AddOrUpdate(e => e.Id,
                new Employee { Id = 1, Name = "Rajib" },
                new Employee { Id = 1, Name = "Ashiq" },
                new Employee { Id = 1, Name = "Zaman" });

            context.Departments.AddOrUpdate(e => e.Id,
                new Department { Id = 1, Name = "A" },
                new Department { Id = 1, Name = "B" },
                new Department { Id = 1, Name = "C" });
        }
    }


    //internal sealed class ConfigurationTest : DbMigrationsConfiguration<TestDbContext>
    //{
    //    public ConfigurationTest()
    //    {
    //        AutomaticMigrationsEnabled = true;
    //        AutomaticMigrationDataLossAllowed = true;
    //    }

    //    protected override void Seed(TestDbContext context)
    //    {
    //        context.Departments.AddOrUpdate(e => e.Id,
    //            new Department { Id = 1, Name = "A" },
    //            new Department { Id = 1, Name = "B" },
    //            new Department { Id = 1, Name = "C" });
    //    }
    //}

}

