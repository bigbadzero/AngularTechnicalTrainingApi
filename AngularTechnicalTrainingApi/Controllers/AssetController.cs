using AngularTechnicalTrainingApi.Data.GenericRepository;
using AngularTechnicalTrainingApi.Domain.Models;
using AngularTechnicalTrainingApi.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularTechnicalTrainingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssetController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly AssetDialogOptionsDTO _dialogOptions;

        public AssetController(IUnitOfWork unitOfWork, IMapper mapper, AssetDialogOptionsDTO dialogOptions)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _dialogOptions = dialogOptions;
        }

        [HttpGet]
        
        public async Task<IActionResult> GetAllActiveAssets()
        {
            var assets = await _unitOfWork.Assets.GetAll(q => q.Retired != true,include: q => q.Include(x => x.Employee).Include(x => x.AssetType));
            var results = _mapper.Map<IList<AssetDTO>>(assets);
            return Ok(results);
        }

        [HttpGet]
        [Route("DialogOptions")]
        public async Task<IActionResult> GetAssetDialogOptions()
        {
            var employees = await _unitOfWork.Employees.GetAll();
            var assetTypes = await _unitOfWork.AssetTypes.GetAll();
            var employeesDTO = _mapper.Map<IList<EmployeeDTO>>(employees);
            var assetTypesDTO = _mapper.Map<IList<AssetTypeDTO>>(assetTypes);
            _dialogOptions.Employees = employeesDTO;
            _dialogOptions.AssetTypes = assetTypesDTO;
            return Ok(_dialogOptions);
        }

        

        [HttpGet("{tagId:int}", Name = "GetAssetByAssetTag")]
        public async Task<IActionResult> GetAssetByAssetTag(int tagId)
        {
            var assets = await _unitOfWork.Assets.Get(q => q.TagID == tagId, include: q => q.Include(x => x.Employee).Include(x => x.AssetType));
            var results = _mapper.Map<AssetDTO>(assets);
            return Ok(results);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsset([FromBody] NewAssetDTO newAssetDTO)
        {
            if (ModelState.IsValid)
            {
                var asset = _mapper.Map<Asset>(newAssetDTO);
                asset.DateAdded = DateTime.Now;
                await _unitOfWork.Assets.Insert(asset);
                await _unitOfWork.Save();
                return CreatedAtRoute("GetAssetByAssetTag", new { tagId = asset.TagID }, asset);

            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsset([FromBody] AssetDTO assetDTO)
        {
            if (ModelState.IsValid)
            {
                var asset = await _unitOfWork.Assets.Get(q => q.TagID == assetDTO.TagID);
                if(asset == null)
                {
                    return BadRequest("Invalid update");
                }
                _mapper.Map(assetDTO, asset);
                _unitOfWork.Assets.Update(asset);
                await _unitOfWork.Save();

                return NoContent();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


    }
}
