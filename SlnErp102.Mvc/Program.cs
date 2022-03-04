
using System.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.EntityFrameworkCore;
using SlnErp102.Api.DTOs.Stocks.Products;
using SlnErp102.Api.Filters;
using SlnErp102.Core.Repository;
using SlnErp102.Core.Repository.Infos.Companies;
using SlnErp102.Core.Repository.Infos.Doctors;
using SlnErp102.Core.Repository.Infos.Employees;
using SlnErp102.Core.Repository.Infos.Hospitals;
using SlnErp102.Core.Repository.Stocks.Products;
using SlnErp102.Core.Service;
using SlnErp102.Core.Service.Infos.Companies;
using SlnErp102.Core.Service.Infos.Doctors;
using SlnErp102.Core.Service.Infos.Employees;
using SlnErp102.Core.Service.Infos.Hospitals;
using SlnErp102.Core.Service.Stocks.Products;
using SlnErp102.Core.UnitOfWork;
using SlnErp102.Data;
using SlnErp102.Data.Repository;
using SlnErp102.Data.Repository.Infos.Companies;
using SlnErp102.Data.Repository.Infos.Doctors;
using SlnErp102.Data.Repository.Infos.Employees;
using SlnErp102.Data.Repository.Infos.Hospitals;
using SlnErp102.Data.Repository.Stocks.Products;
using SlnErp102.Data.UnitOfWork;
using SlnErp102.Mvc.ApiService.Stocks.Products;
using SlnErp102.Service.Services;
using SlnErp102.Service.Services.Infos.Companies;
using SlnErp102.Service.Services.Infos.Doctors;
using SlnErp102.Service.Services.Infos.Employees;
using SlnErp102.Service.Services.Infos.Hospitals;
using SlnErp102.Service.Services.Stocks.Products;




var builder = WebApplication.CreateBuilder(args);


builder.Services.AddHttpClient<ProductEntryApiService>(ops =>
{
    ops.BaseAddress = new Uri("https://localhost:7052/api/");
});

builder.Services.AddHttpClient<CompanyApiService>(ops =>
{
    ops.BaseAddress = new Uri("https://localhost:7052/api/");
});



builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<IHospitalService, HospitalService>();
builder.Services.AddScoped<IHospitalRepository, HospitalRepository>();
builder.Services.AddScoped<IHospitalDetailService, HospitalDetailService>();
builder.Services.AddScoped<IHospitalDetailRepository, HospitalDetailRepository>();
builder.Services.AddScoped<IHospitalBranchService, HospitalBranchService>();
builder.Services.AddScoped<IHospitalBranchRepository, HospitalBranchRepository>();

builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<ICompanyDetailService, CompanyDetailService>();
builder.Services.AddScoped<ICompanyDetailRepository, CompanyDetailRepository>();
builder.Services.AddScoped<ICompanyBranchService, CompanyBranchService>();
builder.Services.AddScoped<ICompanyBranchRepository, CompanyBranchRepository>();
builder.Services.AddScoped<ICompanyTypeService, CompanyTypeService>();
builder.Services.AddScoped<ICompanyTypeRepository, CompanyTypeRepository>();

builder.Services.AddScoped<IDoctorService, DoctorService>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<IDoctorDetailService, DoctorDetailService>();
builder.Services.AddScoped<IDoctorDetailRepository, DoctorDetailRepository>();

builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeDetailService, EmployeeDetailService>();
builder.Services.AddScoped<IEmployeeDetailRepository, EmployeeDetailRepository>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped<IProductEntryRepository, ProductEntryRepository>();
builder.Services.AddScoped<IProductEntryService, ProductEntryService>();

builder.Services.AddScoped<IStockStateRepository, StockStateRepository>();
builder.Services.AddScoped<IStockStateService, StockStateService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(ProductEntryDto));

builder.Services.AddDbContext<SlnDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefCon"), o =>
    {
        o.MigrationsAssembly("SlnErp102.Data");
    });
});
// Add services to the container.
builder.Services.AddControllersWithViews(o =>
{
    o.Filters.Add(new ValidationFilter());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
