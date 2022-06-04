using AngularTechnicalTrainingApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTechnicalTrainingApi.Data.GenericRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Asset> Assets {get;} 
        IGenericRepository<AssetType> AssetTypes { get; }
        IGenericRepository<Employee> Employees { get; }

        Task Save();

    }
}
