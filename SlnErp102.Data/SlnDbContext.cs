using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models;
using SlnErp102.Core.Models.Infos.Companies;
using SlnErp102.Core.Models.Infos.Doctors;
using SlnErp102.Core.Models.Infos.Employees;
using SlnErp102.Core.Models.Infos.Hospitals;
using SlnErp102.Core.Models.Stocks.Products;
using SlnErp102.Data.Configuration.Infos;
using SlnErp102.Data.Configuration.Infos.Companies;
using SlnErp102.Data.Configuration.Infos.Doctors;
using SlnErp102.Data.Configuration.Infos.Employees;
using SlnErp102.Data.Configuration.Infos.Hospitals;
using SlnErp102.Data.Configuration.Stocks.Products;
using SlnErp102.Data.Seed.Info;
using SlnErp102.Data.Seed.Info.Companies;
using SlnErp102.Data.Seed.Info.Doctors;
using SlnErp102.Data.Seed.Info.Employees;
using SlnErp102.Data.Seed.Info.Hospitals;
using SlnErp102.Data.Seed.Stocks.Products;

namespace SlnErp102.Data
{
    public class SlnDbContext : DbContext
    {
        public SlnDbContext(DbContextOptions<SlnDbContext> options) : base(options)
        {

        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorDetail> DoctorDetails { get; set; }

        public DbSet<City> Cities { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyDetail> CompanyDetails { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<CompanyBranch> CompanyBranches { get; set; }


        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<HospitalDetail> HospitalDetails { get; set; }
        public DbSet<HospitalType> HospitalTypes { get; set; }
        public DbSet<HospitalBranch> HospitalBranches { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductEntry> ProductEntries { get; set; }
        public DbSet<StockState> StockStates { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfig());
            modelBuilder.ApplyConfiguration(new CompanyDetailConfig());
            modelBuilder.ApplyConfiguration(new CompanyTypeConfig());
            modelBuilder.ApplyConfiguration(new CompanyBranchConfig());

            modelBuilder.ApplyConfiguration(new DoctorConfig());
            modelBuilder.ApplyConfiguration(new DoctorDetailConfig());


            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new EmployeeDetailConfig());


            modelBuilder.ApplyConfiguration(new HospitalConfig());
            modelBuilder.ApplyConfiguration(new HospitalDetailConfig());
            modelBuilder.ApplyConfiguration(new HospitalTypeConfig());
            modelBuilder.ApplyConfiguration(new HospitalBranchConfig());


            modelBuilder.ApplyConfiguration(new CityConfig());
            modelBuilder.ApplyConfiguration(new DepartmentConfig());

            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ProductEntryConfig());
            modelBuilder.ApplyConfiguration(new StockStateConfig());


            //Seed Datalar
            modelBuilder.ApplyConfiguration(new CitySeed());
            modelBuilder.ApplyConfiguration(new DepartmentSeed());

            modelBuilder.ApplyConfiguration(new HospitalSeed());
            modelBuilder.ApplyConfiguration(new HospitalTypeSeed());
            modelBuilder.ApplyConfiguration(new HospitalBranchSeed());

            modelBuilder.ApplyConfiguration(new CompanyBranchSeed());
            modelBuilder.ApplyConfiguration(new CompanyDetailSeed());
            modelBuilder.ApplyConfiguration(new CompanyTypeSeed());
            modelBuilder.ApplyConfiguration(new CompanySeed());

            modelBuilder.ApplyConfiguration(new DoctorSeed());
            modelBuilder.ApplyConfiguration(new DoctorDetailSeed());

            modelBuilder.ApplyConfiguration(new EmployeeSeed());
            modelBuilder.ApplyConfiguration(new EmployeeDetailSeed());

            modelBuilder.ApplyConfiguration(new ProductSeed());
            modelBuilder.ApplyConfiguration(new ProductEntrySeed());





            //Yontem - 1 =>Cascade islemini degistirmek icin kullanildi.
            //modelBuilder.Entity<Product>()
            //    .HasMany(n => n.ProductEntries)
            //    .WithOne(n => n.Product)
            //    .OnDelete(DeleteBehavior.NoAction);

            //Yontem - 2 =>Cascade islemini degistirmek icin kullanildi.
            modelBuilder.Entity<Company>()
                .HasMany(n => n.ProductEntries)
                .WithOne(n => n.Company)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
