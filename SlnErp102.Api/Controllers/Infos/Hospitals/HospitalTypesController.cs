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
using SlnErp102.Core.Service;

namespace SlnErp102.Api.Controllers.Infos.Hospitals
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalTypesController : ControllerBase
    {
        private readonly IService<HospitalType> _context;
        private readonly IMapper _mapper;

        public HospitalTypesController(IService<HospitalType> context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/HospitalTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HospitalType>>> GetHospitalType()
        {
            var hType = await _context.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<HospitalTypeDto>>(hType));
        }

        // GET: api/HospitalTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HospitalType>> GetHospitalType(int id)
        {
            var hType = await _context.GetByIdAsync(id);
            return Ok(_mapper.Map<HospitalTypeDto>(hType));
        }

        // PUT: api/HospitalTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHospitalType(int id, HospitalTypeDto hTypeDto)
        {
            if (id != hTypeDto.Id)
            {
                return BadRequest();
            }
            _context.Update(_mapper.Map<HospitalType>(hTypeDto));
            return NoContent();
        }

        // POST: api/HospitalTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HospitalType>> PostHospitalType(HospitalTypeDto hTypeDto)
        {
            var hType = await _context.AddAsync(_mapper.Map<HospitalType>(hTypeDto));
            

            return Created(string.Empty,_mapper.Map<HospitalTypeDto>(hType));
        }

        // DELETE: api/HospitalTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHospitalType(int id)
        {
            var hType = await _context.GetByIdAsync(id);
            _context.Remove(hType);
            return NoContent();
        }
    }
}
