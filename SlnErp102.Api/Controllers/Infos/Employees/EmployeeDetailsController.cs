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
using SlnErp102.Core.Service.Infos.Employees;

namespace SlnErp102.Api.Controllers.Infos.Employees
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDetailsController : ControllerBase
    {
        private readonly IEmployeeDetailService _service;
        private readonly IMapper _mapper;

        public EmployeeDetailsController(IEmployeeDetailService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/EmployeeDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDetail>>> GetEmployeeDetail()
        {
            var empDetail = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<EmployeeDetailDto>>(empDetail));
        }

        // GET: api/EmployeeDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDetail>> GetEmployeeDetail(int id)
        {
            var empDetail = await _service.GetByIdAsync(id);
            return Ok(_mapper.Map<EmployeeDetailDto>(empDetail));
        }

        // PUT: api/EmployeeDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeDetail(int id, EmployeeDetailDto empDetailDto)
        {
            if (id != empDetailDto.Id)
            {
                return BadRequest();
            }

            var empDetail = await _service.GetByIdAsync(id);
            empDetail.DepartmentId = empDetailDto.DepartmentId;
            empDetail.EmployeeId = empDetailDto.EmployeeId;
            empDetail.Email = empDetailDto.Email;
            empDetail.Fax = empDetailDto.Fax;
            empDetail.Gsm = empDetailDto.Gsm;
            empDetail.Phone = empDetailDto.Phone;

            _service.Update(_mapper.Map<EmployeeDetail>(empDetail));

            return NoContent();
        }

        // POST: api/EmployeeDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmployeeDetail>> PostEmployeeDetail(EmployeeDetailDto empDetailDto)
        {
            var empDetail = await _service.AddAsync(_mapper.Map<EmployeeDetail>(empDetailDto));
            return Created(string.Empty, _mapper.Map<EmployeeDetailDto>(empDetail));
        }

        // DELETE: api/EmployeeDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeDetail(int id)
        {
            var empDetail = await _service.GetByIdAsync(id);

            _service.Remove(empDetail);
            return NoContent();
        }

        //private bool EmployeeDetailExists(int id)
        //{
        //    return _context.EmployeeDetail.Any(e => e.Id == id);
        //}
    }
}
