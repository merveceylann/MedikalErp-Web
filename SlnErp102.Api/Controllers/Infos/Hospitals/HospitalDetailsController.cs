#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SlnErp102.Api.DTOs.Info.Hospitals;
using SlnErp102.Core.Models.Infos.Hospitals;
using SlnErp102.Core.Service.Infos.Hospitals;

namespace SlnErp102.Api.Controllers.Infos.Hospitals
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalDetailsController : ControllerBase
    {
        private readonly IHospitalDetailService _service;
        private readonly IMapper _mapper;

        public HospitalDetailsController(IHospitalDetailService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/HospitalDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HospitalDetail>>> GetHospitalDetail()
        {
            var hospitalDetail = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<HospitalDetailDto>>(hospitalDetail));
        }

        // GET: api/HospitalDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HospitalDetail>> GetHospitalDetail(int id)
        {
            var hospitalDetail = await _service.GetByIdAsync(id);
            return Ok(_mapper.Map<HospitalDetailDto>(hospitalDetail));
        }

        // PUT: api/HospitalDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHospitalDetail(int id, HospitalDetailDto hospitalDetailDto)
        {
            if (id != hospitalDetailDto.Id)
            {
                return BadRequest();
            }
            var hd = await _service.GetByIdAsync(id);

            hd.Email = hospitalDetailDto.Email;
            hd.Phone = hospitalDetailDto.Phone;
            hd.Gsm = hospitalDetailDto.Gsm;
            hd.Fax = hospitalDetailDto.Fax;
            hd.HospitalBranchId = hospitalDetailDto.HospitalBranchId;
            hd.DepartmentId = hospitalDetailDto.DepartmentId;
            hd.Officer = hospitalDetailDto.Officer;

            _service.Update(_mapper.Map<HospitalDetail>(hd));

            return NoContent();
        }

        // POST: api/HospitalDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HospitalDetail>> PostHospitalDetail(HospitalDetailDto hospitalDetailDto)
        {
            var hd = await _service.AddAsync(_mapper.Map<HospitalDetail>(hospitalDetailDto));
            return Created(string.Empty, _mapper.Map<HospitalDetailDto>(hd));
        }

        // DELETE: api/HospitalDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHospitalDetail(int id)
        {
            var hospitalDetail = await _service.GetByIdAsync(id);
            _service.Remove(hospitalDetail);

            return NoContent();
        }

        //private bool HospitalDetailExists(int id)
        //{
        //    return _context.HospitalDetail.Any(e => e.Id == id);
        //}
    }
}
