using BulkBook.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkBook.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
    }
}
