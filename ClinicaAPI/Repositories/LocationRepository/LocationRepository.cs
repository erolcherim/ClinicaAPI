using ClinicaAPI.DAL.Entities;
using ClinicaAPI.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClinicaAPI.Repositories.LocationRepository
{
    public class LocationRepository : GenericRepository<Location>, ILocationRepository
    {
        public LocationRepository(AppDbContext context) : base(context) { }
        public async Task<List<Location>> GetLocationsAsync() => await _context.Locations.ToListAsync();
    }
}
