#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SlnErp102.Api.DTOs.Info;
using SlnErp102.Core.Models;
using SlnErp102.Core.Service;

namespace SlnErp102.Api.Controllers.Infos
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        
        private readonly ICityService _service;
        private readonly IMapper _mapper;

        public CitiesController(ICityService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>> GetCity()
        {
            var city= await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CityDto>>(city));
        }

        // GET: api/Cities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<City>> GetCity(int id)
        {
            var city = await _service.GetByIdAsync(id);

            return Ok(city);
        }

        // PUT: api/Cities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCity(int id, CityDto city)
        {
            if (id != city.Id)
            {
                return BadRequest();
            }
            _service.Update(_mapper.Map<City>(city));
            return NoContent();
        }

        // POST: api/Cities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<City>> PostCity(CityDto city)
        {
            var cty = await _service.AddAsync(_mapper.Map<City>(city));
            //return CreatedAtAction("GetCity", new { id = city.Id }, cty);
            return Created(string.Empty,_mapper.Map<CityDto>(cty));
        }

        // DELETE: api/Cities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            var city = await _service.GetByIdAsync(id);
            

            _service.Remove(city);

            return NoContent();
        }

        //private bool CityExists(int id)
        //{
        //    return _context.City.Any(e => e.Id == id);
        //}
    }
}
