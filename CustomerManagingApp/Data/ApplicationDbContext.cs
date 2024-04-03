using CustomerManagingApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagingApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
