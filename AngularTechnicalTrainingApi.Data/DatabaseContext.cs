using AngularTechnicalTrainingApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTechnicalTrainingApi.Data
{
    public class DatabaseContext: DbContext
    {
        public  DatabaseContext(DbContextOptions options): base(options)
    {}
    DbSet<AssetType> AssetTypes { get; set; }
    DbSet<Employee> Employees { get; set; }
}
    

}
