#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SlnErp102.Api.DTOs.Info.Employees;
using SlnErp102.Core.Models.Infos.Employees;
using SlnErp102.Core.Models.Infos.Hospitals;
using SlnErp102.Core.Service.Infos.Employees;

namespace SlnErp102.Api.Controllers.Infos.Employees
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _service;
        private readonly IMapper _mapper;

        public EmployeesController(IEmployeeService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployee()
        {
            var employee = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<EmployeeDto>>(employee));
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var employee = await _service.GetByIdAsync(id);
            return Ok(_mapper.Map<EmployeeDto>(employee));
        }

        // PUT: api/Employees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, EmployeeDto employeeDto)
        {
            if (id != employeeDto.Id)
            {
                return BadRequest();
            }

            var emp = await _service.GetByIdAsync(id);

            emp.BirthDay = employeeDto.BirthDay;
            emp.Description = employeeDto.Description;
            emp.WorkEnd = employeeDto.WorkEnd;
            emp.WorkStart = employeeDto.WorkStart;
            emp.CityId = employeeDto.CityId;
            emp.Name = employeeDto.Name;
            emp.Picture = employeeDto.Picture;

            _service.Update(_mapper.Map<Employee>(emp));

            return NoContent();
        }

        // POST: api/Employees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(EmployeeDto employeeDto)
        {
            var emp = await _service.AddAsync(_mapper.Map<Employee>(employeeDto));
            return Created(string.Empty, _mapper.Map<EmployeeDto>(emp));
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var emp = await _service.GetByIdAsync(id);

            _service.Remove(emp);
            return NoContent();
        }

        //private bool EmployeeExists(int id)
        //{
        //    return _context.Employee.Any(e => e.Id == id);
        //}
    }
}
