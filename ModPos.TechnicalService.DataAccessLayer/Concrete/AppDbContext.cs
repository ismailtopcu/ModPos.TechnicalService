using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ModPos.TechnicalService.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModPos.TechnicalService.DataAccessLayer.Concrete
{
    public  class AppDbContext:DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlServer"));
        }

        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceMovements> ServiceMovements { get; set; }
    }
}
