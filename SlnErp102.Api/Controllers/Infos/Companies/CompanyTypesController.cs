#nullable disable
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SlnErp102.Api.DTOs.Info.Companies;
using SlnErp102.Core.Models.Infos.Companies;
using SlnErp102.Core.Service.Infos.Companies;

namespace SlnErp102.Api.Controllers.Infos.Companies
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyTypesController : ControllerBase
    {
        private readonly ICompanyTypeService _service;
        private readonly IMapper _mapper;

        public CompanyTypesController(ICompanyTypeService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/CompanyTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyType>>> GetCompanyType()
        {
            var comType = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CompanyTypeDto>>(comType));
        }

        // GET: api/CompanyTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyType>> GetCompanyType(int id)
        {
            var comType = await _service.GetByIdAsync(id);
            return Ok(_mapper.Map<CompanyTypeDto>(comType));
        }

        // PUT: api/CompanyTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompanyType(int id, CompanyTypeDto comTypeDto)
        {
            if (id != comTypeDto.Id)
            {
                return BadRequest();
            }

            var comType = await _service.GetByIdAsync(id);
            comType.Name = comTypeDto.Name;
            

            _service.Update(_mapper.Map<CompanyType>(comType));
            return NoContent();
        }

        // POST: api/CompanyTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CompanyType>> PostCompanyType(CompanyTypeDto comTypeDto)
        {
            var comType = await _service.AddAsync(_mapper.Map<CompanyType>(comTypeDto));
            return Created(string.Empty, _mapper.Map<CompanyTypeDto>(comType));
        }

        // DELETE: api/CompanyTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanyType(int id)
        {
            var comType = await _service.GetByIdAsync(id);

            _service.Remove(comType);
            return NoContent();
        }

        //private bool CompanyTypeExists(int id)
        //{
        //    return _context.CompanyType.Any(e => e.Id == id);
        //}
    }
}
