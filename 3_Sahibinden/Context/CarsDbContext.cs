using _3_Sahibinden.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Sahibinden.Context
{
    internal class CarsDbContext:DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<CarAdvert> CarAdverts { get; set; }
    }
}
