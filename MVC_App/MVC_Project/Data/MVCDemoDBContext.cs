using Microsoft.EntityFrameworkCore;
using MVC_Project.Models.Domain;
using System.Runtime.CompilerServices;

namespace MVC_Project.Data
{
    public class MVCDemoDBContext : DbContext
    {
        public MVCDemoDBContext(DbContextOptions options) : base(options)
        {

        }

        //This name will be on the table

        public DbSet<Employee> Employees { get; set; }

    }
}
