using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
 
    }
}
