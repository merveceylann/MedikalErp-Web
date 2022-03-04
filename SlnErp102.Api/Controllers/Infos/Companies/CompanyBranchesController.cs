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
    public class CompanyBranchesController : ControllerBase
    {
        private readonly ICompanyBranchService _service;
        private readonly IMapper _mapper;

        public CompanyBranchesController(ICompanyBranchService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/CompanyBranches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyBranch>>> GetCompanyBranch()
        {
            var comBranch = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CompanyBranchDto>>(comBranch));
        }

        // GET: api/CompanyBranches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyBranch>> GetCompanyBranch(int id)
        {
            var comBranch = await _service.GetByIdAsync(id);
            return Ok(_mapper.Map<CompanyBranchDto>(comBranch));
        }

        // PUT: api/CompanyBranches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompanyBranch(int id, CompanyBranchDto comBranchDto)
        {
            if (id != comBranchDto.Id)
            {
                return BadRequest();
            }
            var comBranch = await _service.GetByIdAsync(id);
            comBranch.Name = comBranchDto.Name;
            comBranch.Address = comBranchDto.Address;
            comBranch.InvoiceTitle = comBranchDto.InvoiceTitle;
            comBranch.CityId = comBranchDto.CityId;
            comBranch.CompanyId = comBranchDto.CompanyId;

            _service.Update(_mapper.Map<CompanyBranch>(comBranch));
            return NoContent();
        }

        // POST: api/CompanyBranches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CompanyBranch>> PostCompanyBranch(CompanyBranchDto comBranchDto)
        {
            var comBranch = await _service.AddAsync(_mapper.Map<CompanyBranch>(comBranchDto));
            return Created(string.Empty, _mapper.Map<CompanyBranchDto>(comBranch));
        }

        // DELETE: api/CompanyBranches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanyBranch(int id)
        {
            var comBranch = await _service.GetByIdAsync(id);

            _service.Remove(comBranch);
            return NoContent();
        }

        //private bool CompanyBranchExists(int id)
        //{
        //    return _context.CompanyBranch.Any(e => e.Id == id);
        //}
    }
}
