using AzR.Core.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using MvcPortableArea.Web.Models;
using System.Data.Entity;

namespace AzR.Core.Repositories
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
