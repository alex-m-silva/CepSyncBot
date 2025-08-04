using Domain.Entities;
using Domain.Iterfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly AppDbContext _ctx = new();
        public AddressRepository(AppDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<List<Address>> GetAllAsync()
        {
            return await _ctx.Addresses.ToListAsync();
        }
        public async Task AddAsync(List<Address> addresses)
        {
            await _ctx.Addresses.AddRangeAsync(addresses);
        }

        public async Task<Address?> GetByIdAsync(int id)
        {
            return await
                _ctx.Addresses.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Address?> GetZipCodeAsync(string robot)
        {
            return await
                    _ctx.Addresses.FirstOrDefaultAsync(x => x.Robo == robot);
        }

        public Task<bool> UpdateDataAsync(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
