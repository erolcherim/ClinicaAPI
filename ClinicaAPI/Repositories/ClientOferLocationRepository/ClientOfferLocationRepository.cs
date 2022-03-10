using ClinicaAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaAPI.Repositories.GenericRepository
{
    public class ClientOfferLocationRepository : GenericRepository<ClientOfferLocation>, IClientOfferLocationRepository
    {
        public ClientOfferLocationRepository(AppDbContext context) : base(context) { }
        public async Task<List<ClientOfferLocation>> GetSalesAsync() => await _context.Sales.ToListAsync();
    }
}
