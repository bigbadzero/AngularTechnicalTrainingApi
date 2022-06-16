using AngularTechnicalTrainingApi.Data.GenericRepository;
using AngularTechnicalTrainingApi.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularTechnicalTrainingApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeAssetsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeAssetsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("{employeeId:int}", Name = "GetAssetsByEmployeeId")]
        public async Task<IActionResult> GetAssetsByEmployeeId(int employeeId)
        {
            var assets = await _unitOfWork.Assets.GetAll(q => q.EmployeeID == employeeId && q.Retired != true, include: q => q.Include(x => x.Employee).Include(x => x.AssetType));
            var results = _mapper.Map<IList<AssetDTO>>(assets);
            return Ok(results);
        }


    }
}
