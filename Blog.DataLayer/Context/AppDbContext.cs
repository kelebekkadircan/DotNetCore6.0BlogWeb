using System.Reflection;
using Blog.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.DataLayer.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            

        }

        public DbSet<Article> Articles {get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Category> Categories { get; set; }

        // IEntityTypeConfiguration kullanılan her yeri otomatik tarar ve configure metodunu çalıştırır.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
