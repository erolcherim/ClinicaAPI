using ClinicaAPI.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaAPI.Repositories.GenericRepository
{
    public interface IClientOfferLocationRepository : IGenericRepository<ClientOfferLocation>
    {
        Task<List<ClientOfferLocation>> GetSalesAsync();
    }
}
