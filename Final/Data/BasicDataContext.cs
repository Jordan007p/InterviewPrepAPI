using Final.Models;
using Final.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Final.Data
{
    public class BasicDataContext : DbContext
    {
        public BasicDataContext(DbContextOptions<BasicDataContext> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }    
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData();
        }
    }
}
