using AngularTechnicalTrainingApi.Data.GenericRepository;
using AngularTechnicalTrainingApi.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AngularTechnicalTrainingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssetTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AssetTypeController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAssetTypes()
        {
            var assetTypes = await _unitOfWork.AssetTypes.GetAll();
            var result = _mapper.Map<IList<AssetTypeDTO>>(assetTypes);
            return Ok(result);
        }
    }
}
