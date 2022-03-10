using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaAPI.DAL.Entities;
using ClinicaAPI.Repositories.GenericRepository;

namespace ClinicaAPI.Repositories.OfferRepository
{
    public interface IOfferRepository : IGenericRepository<Offer>
    {
        Task<List<Offer>> GetOffersAsync();
    }
}
