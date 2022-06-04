using AngularTechnicalTrainingApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTechnicalTrainingApi.Data.Configurations
{
    public class AssetConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.HasData(
                new Asset
                {
                    TagID = 1,
                    AssetTypeID = 1,
                    EmployeeID = 1,
                    Description = "Desktop assigned to Admin1",
                    DateAdded = DateTime.Now,
                    Retired = false,
                    DateRetired = null
                },
                new Asset
                {
                    TagID = 2,
                    AssetTypeID = 2,
                    EmployeeID = 1,
                    Description = "Standard Laptop assigned to Admin1",
                    DateAdded = DateTime.Now,
                    Retired = false,
                    DateRetired = null
                },
                new Asset
                {
                    TagID = 3,
                    AssetTypeID = 1,
                    EmployeeID = 2,
                    Description = "Standard Desktop assigned to Admin2",
                    DateAdded = DateTime.Now,
                    Retired = false,
                    DateRetired = null
                },
                new Asset
                {
                    TagID = 4,
                    AssetTypeID = 2,
                    EmployeeID = 2,
                    Description = "Standard Laptop assigned to Admin2",
                    DateAdded = DateTime.Now,
                    Retired = false,
                    DateRetired = null
                }
                ); 
        }
    }
}
