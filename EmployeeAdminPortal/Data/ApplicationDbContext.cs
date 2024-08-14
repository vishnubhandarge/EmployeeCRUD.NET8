using Microsoft.EntityFrameworkCore;
using EmployeeAdminPortal.Models;

namespace EmployeeAdminPortal.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
