using AngularTechnicalTrainingApi.Data.GenericRepository;
using AngularTechnicalTrainingApi.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AngularTechnicalTrainingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssetController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AssetController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAssets()
        {
            var assets = await _unitOfWork.Assets.GetAll();
            var results = _mapper.Map<IList<AssetDTO>>(assets);
            return Ok(results);
        }
    }
}
