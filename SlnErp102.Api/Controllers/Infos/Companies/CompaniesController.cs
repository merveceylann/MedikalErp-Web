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
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyService _service;
        private readonly IMapper _mapper;

        public CompaniesController(ICompanyService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Companies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompany()
        {
            var com=await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CompanyDto>>(com));
        }

        // GET: api/Companies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompany(int id)
        {
            var company = await _service.GetByIdAsync(id);
            return Ok(_mapper.Map<CompanyDto>(company));
        }

        // PUT: api/Companies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(int id, CompanyDto companyDto)
        {
            if (id != companyDto.Id)
            {
                return BadRequest();
            }
            var company = await _service.GetByIdAsync(id);
            company.Name = companyDto.Name;
            company.CompanyTypeId = companyDto.CompanyTypeId;

            _service.Update(_mapper.Map<Company>(company));
            return NoContent();
        }

        // POST: api/Companies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Company>> PostCompany(CompanyDto companyDto)
        {
            var company = await _service.AddAsync(_mapper.Map<Company>(companyDto));
            return Created(string.Empty, _mapper.Map<CompanyDto>(company));
        }

        // DELETE: api/Companies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var com = await _service.GetByIdAsync(id);

            _service.Remove(com);
            return NoContent();
        }

        //private bool CompanyExists(int id)
        //{
        //    return _context.Company.Any(e => e.Id == id);
        //}
    }
}
