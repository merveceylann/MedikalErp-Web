using System.Text;
using Newtonsoft.Json;
using SlnErp102.Api.DTOs.Info.Companies;
using SlnErp102.Api.DTOs.Stocks.Products;

namespace SlnErp102.Mvc.ApiService.Stocks.Products
{
    public class ProductEntryApiService
    {
        private readonly HttpClient _httpClient;

        public ProductEntryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductEntryDistinctDto>?> GetAllAsync()
        {
            IEnumerable<ProductEntryDistinctDto>? pEntryDtos;
            var response = await _httpClient.GetAsync("ProductEntries");

            //http://localhost:43333/api/productentry

            if (response.IsSuccessStatusCode)
            {
                pEntryDtos =
                    JsonConvert.DeserializeObject<IEnumerable<ProductEntryDistinctDto>>(
                        await response.Content.ReadAsStringAsync());
            }
            else
            {
                pEntryDtos = null;
            }

            return pEntryDtos;
        }

        public async Task<IEnumerable<ProductDto>> Products()
        {
            IEnumerable<ProductDto>? pro;
            var response = await _httpClient.GetAsync("Products");
            if (response.IsSuccessStatusCode)
            {
                pro = JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                pro = null;
            }
            return pro;
        }

        public async Task<IEnumerable<ProductEntryDto>?> GetProEntryByIvnoAsync(string ivno)
        {
            IEnumerable<ProductEntryDto>? pEntryDtos;
            var response = await _httpClient.GetAsync($"ProductEntries/a/{ivno}");
            //ProductEntries/a/1234
            //ProductEntries/a/5493
            if (response.IsSuccessStatusCode)
            {
                pEntryDtos =
                    JsonConvert.DeserializeObject<IEnumerable<ProductEntryDto>>(
                        await response.Content.ReadAsStringAsync());
            }
            else
            {
                pEntryDtos = null;
            }

            return pEntryDtos;
        }

        public async Task<ProductEntryDto> AddAsync(ProductEntryDto productEntryDto)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(productEntryDto), Encoding.UTF8,
                "application/json");
            var response = await _httpClient.PostAsync("ProductEntries", stringContent);
            if (response.IsSuccessStatusCode)
            {
                productEntryDto = JsonConvert.DeserializeObject<ProductEntryDto>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                productEntryDto = null;
            }


            return productEntryDto;

        }
    }
    public class CompanyApiService
    {
        private readonly HttpClient _httpClient;

        public CompanyApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<CompanyDto>?> GetAllAsync()
        {
            IEnumerable<CompanyDto>? companyDtos;
            var response = await _httpClient.GetAsync("Companies");
            if (response.IsSuccessStatusCode)
            {
                companyDtos = JsonConvert.DeserializeObject<IEnumerable<CompanyDto>>(await response.Content.ReadAsStringAsync());
                return companyDtos;
            }
            else
            {
                return companyDtos = null;
            }
        }
    }
}
