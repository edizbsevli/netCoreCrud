using Deneme.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Deneme.Views.Data
{
    public class MVCDemoDbContext : DbContext
    {
            public MVCDemoDbContext(DbContextOptions<MVCDemoDbContext> options) : base(options)
        {
            
        }

        public DbSet <Employee> Employees {  get; set; }
    }
}
