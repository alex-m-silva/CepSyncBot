using Domain.Entities;
using Domain.Iterfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using EFCore.BulkExtensions;

namespace Infrastructure.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly AppDbContext _ctx;
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
            await _ctx.BulkInsertAsync(addresses);
        }

        public async Task<Address?> GetByIdAsync(int id)
        {
            return await _ctx.Addresses.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<Address?> GetZipCodeAsync(string robot)
        {
            return await _ctx.Addresses.FirstOrDefaultAsync(x => 
            (x.Robo == robot && x.Status == Domain.Enums.EnumStatus.EmAndamento)
            ||
            (string.IsNullOrEmpty(x.Robo) && x.Status == Domain.Enums.EnumStatus.Aberto));
        }

        public async Task<bool> UpdateDataAsync(Address address)
        {
            _ctx.Addresses.Update(address);
            return await _ctx.SaveChangesAsync() > 0;
        }
    }
}
