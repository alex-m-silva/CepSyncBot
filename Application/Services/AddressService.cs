using Domain.Iterfaces.Repositories;
using Domain.Iterfaces.Services;
using Domain.Models;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public Task AddAsync(List<AddressModel> addresses)
        {
            throw new NotImplementedException();
        }

        public Task<List<AddressModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AddressModel> GetZipCodeAsync(string robot)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDataAsync(AddressModel address)
        {
            throw new NotImplementedException();
        }
    }
}
