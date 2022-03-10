using ClinicaAPI.DAL.Entities;
using ClinicaAPI.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaAPI.Repositories.CityRepository
{
    public interface ICityRepository : IGenericRepository<City>
    {
        Task<List<City>> GetCitiesAsync();
    }
}
