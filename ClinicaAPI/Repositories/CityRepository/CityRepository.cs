using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClinicaAPI.Repositories.GenericRepository;
using ClinicaAPI.DAL.Entities;

namespace ClinicaAPI.Repositories.CityRepository
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        public CityRepository(AppDbContext context) : base(context) { }
        public async Task<List<City>> GetCitiesAsync() => await _context.Cities.ToListAsync();
    }
}


