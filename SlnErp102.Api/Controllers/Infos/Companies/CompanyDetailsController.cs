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
    public class CompanyDetailsController : ControllerBase
    {
        private readonly ICompanyDetailService _service;
        private readonly IMapper _mapper;

        public CompanyDetailsController(ICompanyDetailService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/CompanyDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyDetail>>> GetCompanyDetail()
        {
            var comDetails = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CompanyDetailDto>>(comDetails));
        }

        // GET: api/CompanyDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyDetail>> GetCompanyDetail(int id)
        {
            var comDetail = await _service.GetByIdAsync(id);
            return Ok(_mapper.Map<CompanyDetailDto>(comDetail));
        }

        // PUT: api/CompanyDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompanyDetail(int id, CompanyDetailDto comDetailDto)
        {
            if (id != comDetailDto.Id)
            {
                return BadRequest();
            }

            var comDetail = await _service.GetByIdAsync(id);
            comDetail.Email = comDetailDto.Email;
            comDetail.Phone = comDetailDto.Phone;
            comDetail.Gsm = comDetailDto.Gsm;
            comDetail.Fax = comDetailDto.Fax;
            comDetail.CompanyId = comDetailDto.CompanyId;
            comDetail.Officer = comDetailDto.Officer;
            comDetail.DepartmentId = comDetailDto.DepartmentId;

            _service.Update(_mapper.Map<CompanyDetail>(comDetail));
            return NoContent();
        }

        // POST: api/CompanyDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CompanyDetail>> PostCompanyDetail(CompanyDetailDto comDetailDto)
        {
            var comDetail = await _service.AddAsync(_mapper.Map<CompanyDetail>(comDetailDto));
            return Created(string.Empty, _mapper.Map<CompanyDetailDto>(comDetail));
        }

        // DELETE: api/CompanyDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanyDetail(int id)
        {
            var comDetail = await _service.GetByIdAsync(id);

            _service.Remove(comDetail);
            return NoContent();
        }

        //private bool CompanyDetailExists(int id)
        //{
        //    return _context.CompanyDetail.Any(e => e.Id == id);
        //}
    }
}
