using ClinicaAPI.DAL.Entities;
using ClinicaAPI.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaAPI.Repositories.LocationRepository
{
    public interface ILocationRepository : IGenericRepository<Location>
    {
        Task<List<Location>> GetLocationsAsync();
    }
}
