using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System;

namespace DataAccess.Context
{
    public class ReCapDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReCapDb;Trusted_Connection=true");
            //Domain'e hizmet eden class'lar ile Db'nin bağlanması
        }
        public DbSet<Car> Cars { get; set; }
        //public DbSet<Color> Colors { get; set; }
        //public DbSet<Brand> Brands { get; set; }

    }
}
