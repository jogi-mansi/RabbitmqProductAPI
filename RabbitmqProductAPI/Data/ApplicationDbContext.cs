using Microsoft.EntityFrameworkCore;
using RabbitmqProductAPI.Models;

namespace RabbitmqProductAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Product> Products  { get; set; }
    }
}
