using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaAPI.Repositories.GenericRepository;
using ClinicaAPI.DAL;
using Microsoft.EntityFrameworkCore;
using ClinicaAPI.DAL.Entities;

namespace ClinicaAPI.Repositories.OfferRepository
{
    public class OfferRepository : GenericRepository<Offer>, IOfferRepository
    {
        public OfferRepository(AppDbContext context) : base(context) { }
        public async Task<List<Offer>> GetOffersAsync() => await _context.Offers.ToListAsync();
    }
}
