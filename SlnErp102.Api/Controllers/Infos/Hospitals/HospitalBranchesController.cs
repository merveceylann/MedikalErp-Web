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
    public class HospitalBranchesController : ControllerBase
    {
        private readonly IHospitalBranchService _service;
        private readonly IMapper _mapper;

        public HospitalBranchesController(IHospitalBranchService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/HospitalBranches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HospitalBranch>>> GetHospitalBranch()
        {
            var hospitalBranch = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<HospitalBranchDto>>(hospitalBranch));
        }

        // GET: api/HospitalBranches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HospitalBranch>> GetHospitalBranch(int id)
        {
            var hospitalBranch = await _service.GetByIdAsync(id);
            

            return Ok(_mapper.Map<HospitalBranchDto>(hospitalBranch));
        }

        // PUT: api/HospitalBranches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHospitalBranch(int id, HospitalBranchDto hospitalBranchDto)
        {
            if (id != hospitalBranchDto.Id)
            {
                return BadRequest();
            }

            var hb = await _service.GetByIdAsync(id);

            hb.Address = hospitalBranchDto.Address;
            hb.InvoiceTitle=hospitalBranchDto.InvoiceTitle;
            hb.Name=hospitalBranchDto.Name;
            hb.CityId=hospitalBranchDto.CityId;
            hb.HospitalId = hospitalBranchDto.HospitalId;

            _service.Update(_mapper.Map<HospitalBranch>(hb));

            return NoContent();
        }

        // POST: api/HospitalBranches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HospitalBranch>> PostHospitalBranch(HospitalBranchDto hospitalBranchDto)
        {
            var hb=await _service.AddAsync(_mapper.Map<HospitalBranch>(hospitalBranchDto));

            return Created(string.Empty, _mapper.Map<HospitalBranchDto>(hb));
        }

        // DELETE: api/HospitalBranches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHospitalBranch(int id)
        {
            var hospitalBranch = await _service.GetByIdAsync(id);
            _service.Remove(hospitalBranch);

            return NoContent();
        }

        //private bool HospitalBranchExists(int id)
        //{
        //    return _context.HospitalBranch.Any(e => e.Id == id);
        //}
    }
}
