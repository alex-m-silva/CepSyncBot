using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Iterfaces.Services
{
    public interface IAddressService
    {
        Task AddAsync(List<AddressModel> addresses);

        Task<bool> UpdateDataAsync(AddressModel address);
        Task<AddressModel> GetZipCodeAsync(string robot);
        Task<List<AddressModel>> GetAllAsync();
    }
}
