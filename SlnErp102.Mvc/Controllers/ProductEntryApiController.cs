using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using SlnErp102.Api.DTOs.Stocks.Products;
using SlnErp102.Core.Models.Stocks.Products;
using SlnErp102.Mvc.ApiService.Stocks.Products;

namespace SlnErp102.Mvc.Controllers
{
    public class ProductEntryApiController : Controller
    {
        private readonly ProductEntryApiService _productEntryApiService;
        private readonly CompanyApiService _companyApiService;
        private readonly ProductEntryDto _productEntryDto;
        private readonly IMapper _mapper;


        public ProductEntryApiController(ProductEntryApiService productEntryApiService, IMapper mapper, CompanyApiService companyApiService, ProductEntryDto productEntryDto)
        {
            _productEntryApiService = productEntryApiService;
            _companyApiService = companyApiService;
            _productEntryDto = productEntryDto;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            var productEnrty = await _productEntryApiService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<ProductEntryDistinctDto>>(productEnrty));
        }

        [HttpGet]
        public JsonResult getProductCode()
        {
            //List<ProductDto> product = new List<ProductDto>();

            var proCode = _productEntryApiService.Products().Result;

            return Json(proCode);
            //return new JsonResult { Data = proCode, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public async Task<IActionResult> Details(string ivno)
        {
            var pEntry = await _productEntryApiService.GetProEntryByIvnoAsync(ivno);
            return View(_mapper.Map<IEnumerable<ProductEntryDto>>(pEntry));
        }

        public async Task<IActionResult> Create()
        {
            //getProductCode();
            List<SelectListItem> listCompany = new List<SelectListItem>();
            var CompanyItem = new SelectListItem()
            {
                Value = "",
                Text = "Select Company"
            };
            listCompany.Insert(0, CompanyItem);
            List<SelectListItem> CompanyItemList = (from s in _companyApiService.GetAllAsync().Result
                                                    select new SelectListItem()
                                                    {
                                                        Text = s.Name,
                                                        Value = s.Id.ToString()
                                                    }).ToList();
            listCompany.AddRange(CompanyItemList);
            TempData["Company"] = JsonConvert.SerializeObject(listCompany); //hata burda çözüldü ama tam anlamadım
            ViewBag.Company = listCompany;


            List<SelectListItem> listEntryType = new List<SelectListItem>();
            listEntryType.Insert(0, new SelectListItem()
            {
                Value = "",
                Text = "Select Entry Type"
            });
            var EntryTypeItem = new SelectListItem()
            {
                Value = 1.ToString(),
                Text = "Normal"
            };
            listEntryType.Add(EntryTypeItem);
            EntryTypeItem = new SelectListItem()
            {
                Value = 2.ToString(),
                Text = "Muhtelif"
            };
            listEntryType.Add(EntryTypeItem);
            TempData["EntryType"] = JsonConvert.SerializeObject(listEntryType);
            ViewBag.EntryType = listEntryType;

            return View();
        }

        [HttpPost]
        public IActionResult Create([FromBody] int id, string productCode)
        {

            return RedirectToAction("Index");
        }
        [HttpPost]
        public JsonResult save([FromBody]ProductPostUpDto postData)
        {
            if (postData.CompanyId>0)
            {

                //foreach (var item in postData.Products)
                //{
                //    _productEntryDto.EntryDate = postData.EntryDate;
                //    _productEntryDto.CompanyId = postData.CompanyId;
                //    _productEntryDto.InvoiceNumber = postData.InvoiceNumber;
                //    _productEntryDto.EntryTypeId = postData.EntryTypeId;
                //    _productEntryDto.Description = postData.Description;
                //    _productEntryDto.CompanyName = postData.CompanyName;
                //    _productEntryDto.LotSerial = item.LotSerial;
                //    _productEntryDto.ProductId = item.ProductId;
                //    _productEntryDto.Quantity = item.Quantity;
                //    _productEntryDto.ProductionDate = item.ProductionDate;
                //    _productEntryDto.Barcode = item.Barcode;
                //    _productEntryDto.ProductProductCode = item.ProductCode;
                //    _productEntryDto.ExpirationDate = item.ExpirationDate;
                //    var pro = _productEntryApiService.AddAsync(_productEntryDto).Result;
                //}

                //return Json(data=="True");
                return Json(new { status = "true"});
            }

            return Json(new { status = "false" }); 
        }
    }
}
