using Microsoft.EntityFrameworkCore;
using UserLogIn.Models;

namespace UserLogIn.Views.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        
        public DbSet<User> Users { get; set; }
    }
}
