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
    public class AssetTypeConfiguration: IEntityTypeConfiguration<AssetType>
    {
        public void Configure(EntityTypeBuilder<AssetType> builder)
        {
            builder.HasData(
                new AssetType
                {
                    Id = 1,
                    Name = "Desktop"
                },
                new AssetType
                {
                    Id = 2,
                    Name = "Laptop"
                },
                new AssetType
                {
                    Id = 3,
                    Name = "Display"
                },
                new AssetType
                {
                    Id = 4,
                    Name = "Phone"
                },
                new AssetType
                {
                    Id = 5,
                    Name = "External Hard Drive"
                },
                new AssetType
                {
                    Id = 6,
                    Name = "Other"
                }
                );
        }
    }
}
