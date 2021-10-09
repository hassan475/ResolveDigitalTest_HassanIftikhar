using Microsoft.EntityFrameworkCore;

namespace ResolveDigitalTest.Models
{
    public class EmployeeDbContext: DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options):base(options)
        {
                
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
