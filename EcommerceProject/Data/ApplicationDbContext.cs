using EcommerceProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //categories is a name of table in the db
        public DbSet<Category> Categories { get; set; }
    }
}
