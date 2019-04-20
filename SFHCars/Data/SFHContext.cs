using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SFHCars.Models;

namespace SFHCars.Data
{
    public class SFHContext: DbContext
    {
        public SFHContext(DbContextOptions<SFHContext>options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<SalesPerson> SalesPeople { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Car");
            modelBuilder.Entity<Branch>().ToTable("Branch");
            modelBuilder.Entity<SalesPerson>().ToTable("SalesPerson");

        }
    }
}
