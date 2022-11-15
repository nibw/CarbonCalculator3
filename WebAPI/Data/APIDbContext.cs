using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {

        }

        public DbSet<Household> Households { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<VehicleCategory> VehicleCategories { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Transportation> Transportations { get; set; }
        public DbSet<CarbonType> CarbonTypes { get; set; }
        public DbSet<VehicleCapacity> VehicleCapacities { get; set; }
        public DbSet<VehicleEmision> VehicleEmisions { get; set; }
        public DbSet<Periode> Periodes { get; set; }
    }
}
