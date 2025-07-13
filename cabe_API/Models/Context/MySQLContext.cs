using Microsoft.EntityFrameworkCore;

namespace cabe_API.Models.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        public DbSet<Contact> Contacts { get; set; }
    }
}
