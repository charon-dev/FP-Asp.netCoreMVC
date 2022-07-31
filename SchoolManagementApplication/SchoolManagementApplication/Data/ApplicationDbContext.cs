using Microsoft.EntityFrameworkCore;
using SchoolManagementApplication.Models;

namespace SchoolManagementApplication.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Student> students { get; set; }
        public DbSet<Sector> sectors { get; set; }
        public DbSet<Module> modules { get; set; }

    }
}
