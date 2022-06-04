using AngularTechnicalTrainingApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTechnicalTrainingApi.Data.GenericRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        //template
        //private IGenericRepository<> _something;
        private IGenericRepository<Asset> _assets;
        private IGenericRepository<AssetType> _assetTypes;
        private IGenericRepository<Employee> _employees;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        //template
        //public IGenericRepository<> something => _something ?? new GenericRepository<>(_context);
        public IGenericRepository<Asset> Assets => _assets ?? new GenericRepository<Asset>(_context);
        public IGenericRepository<AssetType> AssetTypes => _assetTypes ?? new GenericRepository<AssetType>(_context);
        public IGenericRepository<Employee> Employees => _employees ?? new GenericRepository<Employee>(_context);



        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
