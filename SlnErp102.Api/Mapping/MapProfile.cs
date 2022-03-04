using AutoMapper;
using SlnErp102.Api.DTOs.Info;
using SlnErp102.Api.DTOs.Info.Companies;
using SlnErp102.Api.DTOs.Info.Doctors;
using SlnErp102.Api.DTOs.Info.Employees;
using SlnErp102.Api.DTOs.Info.Hospitals;
using SlnErp102.Api.DTOs.Stocks.Products;
using SlnErp102.Core.Models;
using SlnErp102.Core.Models.Infos.Companies;
using SlnErp102.Core.Models.Infos.Doctors;
using SlnErp102.Core.Models.Infos.Employees;
using SlnErp102.Core.Models.Infos.Hospitals;
using SlnErp102.Core.Models.Stocks.Products;

namespace SlnErp102.Api.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<City, CityDto>();
            CreateMap<CityDto, City>();

            CreateMap<Department, DepartmentDto>();
            CreateMap<DepartmentDto, Department>();

            CreateMap<HospitalType, HospitalTypeDto>();
            CreateMap<HospitalTypeDto, HospitalType>();

            CreateMap<Hospital, HospitalDto>();
            CreateMap<HospitalDto, Hospital>();

            CreateMap<HospitalBranch, HospitalBranchDto>();
            CreateMap<HospitalBranchDto, HospitalBranch>();

            CreateMap<Doctor, DoctorDto>();
            CreateMap<DoctorDto, Doctor>();

            CreateMap<DoctorDetail, DoctorDetailDto>();
            CreateMap<DoctorDetailDto, DoctorDetail>();

            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();

            CreateMap<EmployeeDetail, EmployeeDetailDto>();
            CreateMap<EmployeeDetailDto, EmployeeDetail>();

            CreateMap<Company, CompanyDto>();
            CreateMap<CompanyDto, Company>();

            CreateMap<CompanyDetail, CompanyDetailDto>();
            CreateMap<CompanyDetailDto, CompanyDetail>();

            CreateMap<CompanyBranch, CompanyBranchDto>();
            CreateMap<CompanyBranchDto, CompanyBranch>();

            CreateMap<CompanyType, CompanyTypeDto>();
            CreateMap<CompanyTypeDto, CompanyType>();
            
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            
            CreateMap<ProductEntry, ProductEntryDto>();
            CreateMap<ProductEntryDto, ProductEntry>();
            
            CreateMap<ProductEntry, ProductEntryDistinctDto>();
            CreateMap<ProductEntryDistinctDto, ProductEntry>();
            
        }
    }
}
