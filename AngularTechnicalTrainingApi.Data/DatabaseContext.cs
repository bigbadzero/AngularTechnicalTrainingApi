using AngularTechnicalTrainingApi.Data.Configurations;
using AngularTechnicalTrainingApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTechnicalTrainingApi.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AssetTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new AssetConfiguration());
        }


        DbSet<AssetType> AssetTypes { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Asset> Assets { get; set; }

    }


}
