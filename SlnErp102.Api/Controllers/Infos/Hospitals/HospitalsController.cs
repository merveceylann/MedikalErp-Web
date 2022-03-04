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
    public class HospitalsController : ControllerBase
    {
        private readonly IHospitalService _service;
        private readonly IMapper _mapper;

        public HospitalsController(IHospitalService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Hospitals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hospital>>> GetHospital()
        {
            var hos = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<HospitalDto>>(hos));
        }

        // GET: api/Hospitals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hospital>> GetHospital(int id)
        {
            var hos = await _service.GetByIdAsync(id);

            return Ok(_mapper.Map<HospitalDto>(hos));
        }

        // PUT: api/Hospitals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHospital(int id, HospitalDto hosDto)
        {
            if (id != hosDto.Id)
            {
                return BadRequest();
            }

            var hos = await _service.GetByIdAsync(id);

            hos.HospitalName = hosDto.HospitalName;
            hos.HospitalTypeId = hosDto.HospitalTypeId;

            _service.Update(_mapper.Map<Hospital>(hos));

            return NoContent();
        }

        // POST: api/Hospitals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hospital>> PostHospital(HospitalDto hosDto)
        {
           var hst=await _service.AddAsync(_mapper.Map<Hospital>(hosDto));
           return Created(string.Empty,_mapper.Map<HospitalDto>(hst));
        }

        // DELETE: api/Hospitals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHospital(int id)
        {
            var hos = await _service.GetByIdAsync(id);
            
           _service.Remove(hos);
            return NoContent();
        }

        //private bool HospitalExists(int id)
        //{
        //    return _context.Hospital.Any(e => e.Id == id);
        //}
    }
}
