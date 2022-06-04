using AngularTechnicalTrainingApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTechnicalTrainingApi.Data
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Admin1",
                    Email = "Admin1@gmail.com",
                    Password = "Admin1Password!"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Admin2",
                    Email = "Admin2@gmail.com",
                    Password = "Admin2Password!"
                }
                );
        }
    }
}
