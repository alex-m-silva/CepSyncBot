using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Iterfaces.Repositories
{
    public interface IAddressRepository
    {
        Task AddAsync(List<Address> addresses);

        Task<bool> UpdateDataAsync(Address address);
        Task<Address?> GetZipCodeAsync(string robot);
        Task<Address?> GetByIdAsync(int id);
        Task<List<Address>> GetAllAsync();
    }
}
