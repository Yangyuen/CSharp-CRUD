using Microsoft.EntityFrameworkCore;
using practice.Models;

namespace practice.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Student> Students {get; set;}
    }
}