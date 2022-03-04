#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SlnErp102.Api.DTOs.Stocks.Products;
using SlnErp102.Core.Models.Stocks.Products;
using SlnErp102.Core.Service.Stocks.Products;

namespace SlnErp102.Api.Controllers.Stocks.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;
        private readonly IMapper _mapper;

        public ProductsController(IProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            var pro=await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ProductDto>>(pro));
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var pro = await _service.GetByIdAsync(id);
            return Ok(_mapper.Map<ProductDto>(pro));
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, ProductDto proDto)
        {
            if (id != proDto.Id)
            {
                return BadRequest();
            }

            var pro=await _service.GetByIdAsync(id);
            pro.Description = proDto.Description;
            pro.BranchNoId = proDto.BranchNoId;
            pro.EntryDate = proDto.EntryDate;
            pro.Picture = proDto.Picture;
            pro.ProductCode = proDto.ProductCode;
            pro.SutCode = proDto.SutCode;
            pro.SutDescription = proDto.SutDescription;
            pro.SutPrice = proDto.SutPrice;
            pro.CompanyId = proDto.CompanyId;

            _service.Update(_mapper.Map<Product>(pro));

            return NoContent();
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(ProductDto proDto)
        {
            var pro = await _service.AddAsync(_mapper.Map<Product>(proDto));
            return Created(string.Empty, _mapper.Map<ProductDto>(pro));
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var pro = await _service.GetByIdAsync(id);

            _service.Remove(pro);
            return NoContent();
        }

        //private bool ProductExists(int id)
        //{
        //    return _context.Product.Any(e => e.Id == id);
        //}
    }
}
