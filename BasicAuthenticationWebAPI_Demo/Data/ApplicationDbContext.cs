using BasicAuthenticationWebAPI_Demo.Models;
using System.Data.Entity;

namespace BasicAuthenticationWebAPI_Demo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext():base("UsersDB")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}