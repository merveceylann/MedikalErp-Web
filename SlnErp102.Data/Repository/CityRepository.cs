using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SlnErp102.Core.Models;
using SlnErp102.Core.Repository;

namespace SlnErp102.Data.Repository
{
    public class CityRepository:Repository<City>,ICityRepository
    {
        private SlnDbContext SlnDbContext{get=>_db as SlnDbContext;}

        public CityRepository(SlnDbContext db):base(db)
        {
            
        }
    }
}

