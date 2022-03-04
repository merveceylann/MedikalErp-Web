#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SlnErp102.Api.DTOs.Info.Companies;
using SlnErp102.Api.DTOs.Info.Doctors;
using SlnErp102.Core.Models.Infos.Doctors;
using SlnErp102.Core.Service.Infos.Doctors;

namespace SlnErp102.Api.Controllers.Infos.Doctors
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _service;
        private readonly IMapper _mapper;

        public DoctorsController(IDoctorService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Doctors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Doctor>>> GetDoctor()
        {
            var doc=await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<DoctorDto>>(doc));
        }

        // GET: api/Doctors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Doctor>> GetDoctor(int id)
        {
            var doctor = await _service.GetByIdAsync(id);
            return Ok(_mapper.Map<DoctorDto>(doctor));
        }

        // PUT: api/Doctors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDoctor(int id, DoctorDto doctorDto)
        {
            if (id != doctorDto.Id)
            {
                return BadRequest();
            }

            var doc= await _service.GetByIdAsync(id);
            doc.Name = doctorDto.Name;
            doc.CityId = doctorDto.CityId;
            doc.BirthDay = doctorDto.BirthDay;
            doc.ClinicAddress = doctorDto.ClinicAddress;

            _service.Update(_mapper.Map<Doctor>(doc));

            return NoContent();
        }

        // POST: api/Doctors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Doctor>> PostDoctor(DoctorDto doctorDto)
        {
            var doc = await _service.AddAsync(_mapper.Map<Doctor>(doctorDto));
            return Created(string.Empty, _mapper.Map<DoctorDto>(doc));
        }

        // DELETE: api/Doctors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            var doc = await _service.GetByIdAsync(id);

            _service.Remove(doc);
            return NoContent();
        }

        //private bool DoctorExists(int id)
        //{
        //    return _context.Doctor.Any(e => e.Id == id);
        //}
    }
}
