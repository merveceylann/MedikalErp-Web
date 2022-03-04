#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SlnErp102.Api.DTOs.Info.Doctors;
using SlnErp102.Core.Models.Infos.Doctors;
using SlnErp102.Core.Service.Infos.Doctors;

namespace SlnErp102.Api.Controllers.Infos.Doctors
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorDetailsController : ControllerBase
    {
        private readonly IDoctorDetailService _service;
        private readonly IMapper _mapper;

        public DoctorDetailsController(IDoctorDetailService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/DoctorDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DoctorDetail>>> GetDoctorDetail()
        {
            var docDetail = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<DoctorDetailDto>>(docDetail));
        }

        // GET: api/DoctorDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DoctorDetail>> GetDoctorDetail(int id)
        {
            var docDetail = await _service.GetByIdAsync(id);
            return Ok(_mapper.Map<DoctorDetailDto>(docDetail));
        }

        // PUT: api/DoctorDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDoctorDetail(int id, DoctorDetailDto docDetailDto)
        {
            if (id != docDetailDto.Id)
            {
                return BadRequest();
            }

            var docDetail = await _service.GetByIdAsync(id);
            docDetail.Email = docDetailDto.Email;
            docDetail.Phone = docDetailDto.Phone;
            docDetail.Fax = docDetailDto.Fax;
            docDetail.HospitalId = docDetailDto.HospitalId;
            docDetail.DoctorId = docDetailDto.DoctorId;
            docDetail.Gsm = docDetailDto.Gsm;

            _service.Update(_mapper.Map<DoctorDetail>(docDetail));

            return NoContent();
        }

        // POST: api/DoctorDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DoctorDetail>> PostDoctorDetail(DoctorDetailDto docDetailDto)
        {
            var docDetail = await _service.AddAsync(_mapper.Map<DoctorDetail>(docDetailDto));
            return Created(string.Empty, _mapper.Map<DoctorDetailDto>(docDetail));
        }

        // DELETE: api/DoctorDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctorDetail(int id)
        {
            var docDetail = await _service.GetByIdAsync(id);

            _service.Remove(docDetail);
            return NoContent();
        }

        //private bool DoctorDetailExists(int id)
        //{
        //    return _context.DoctorDetail.Any(e => e.Id == id);
        //}
    }
}
