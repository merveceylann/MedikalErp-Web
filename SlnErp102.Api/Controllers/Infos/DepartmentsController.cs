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
    public class DepartmentsController : ControllerBase
    {
        private readonly IService<Department> _context;
        private readonly IMapper _mapper;

        public DepartmentsController(IService<Department> context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Departments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartment()
        {
            var dep = await _context.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<DepartmentDto>>(dep));
        }

        // GET: api/Departments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetDepartment(int id)
        {
            var department = await _context.GetByIdAsync(id);
            return Ok(_mapper.Map<DepartmentDto>(department));
        }

        // PUT: api/Departments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartment(int id, DepartmentDto depDto)
        {
            if (id != depDto.Id)
            {
                return BadRequest();
            }

            _context.Update(_mapper.Map<Department>(depDto));
            return NoContent();
        }

        // POST: api/Departments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Department>> PostDepartment(DepartmentDto departmentDto)
        {
            var dep = await _context.AddAsync(_mapper.Map<Department>(departmentDto));
                return Created(string.Empty, _mapper.Map<Department>(dep));
        }

        // DELETE: api/Departments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var department = await _context.GetByIdAsync(id);
            _context.Remove(department);
            return NoContent();
        }

        //private bool DepartmentExists(int id)
        //{
        //    return _context.Department.Any(e => e.Id == id);
        //}
    }
}
