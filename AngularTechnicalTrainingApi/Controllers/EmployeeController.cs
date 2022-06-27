using AngularTechnicalTrainingApi.Data.GenericRepository;
using AngularTechnicalTrainingApi.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AngularTechnicalTrainingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _unitOfWork.Employees.GetAll();
            var results = _mapper.Map<IList<EmployeeDTO>>(employees);
            return Ok(results);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee([FromBody]EmployeeDTO employeeDTO)
        {
            if (ModelState.IsValid)
            {
                var employee = await _unitOfWork.Employees.Get(q => q.Id == employeeDTO.Id);
                if(employee == null)
                {
                    return BadRequest("Invalid Employee");
                }
                _mapper.Map(employeeDTO, employee);
                _unitOfWork.Employees.Update(employee);
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
