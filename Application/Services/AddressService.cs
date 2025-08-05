using Application.Adapters;
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

        public  async Task<List<AddressModel>> GetAllAsync()
        {
            var address = await _addressRepository.GetAllAsync();
            if(address == null)
            {
                throw new Exception("Não foi possivel buscar os endereços");
            }
            return AddressAdapter.MapForModelList(address);
        }

        public async Task<AddressModel> GetZipCodeAsync(string robot)
        {
            var address = await _addressRepository.GetZipCodeAsync(robot);
            if (address == null)
            {
                throw new Exception("Não foi possivel buscar o endereço");
            }
            address.Status = Domain.Enums.EnumStatus.EmAndamento;
            address.Robo = robot;
            await _addressRepository.UpdateDataAsync(address);
            return AddressAdapter.MapForModel(address);
        }

        public async Task AddAsync(List<AddressModel> addresses)
        {
            var domain = AddressAdapter.MapForEntityList(addresses);
            await _addressRepository.AddAsync(domain);
        }
        public async Task<bool> UpdateDataAsync(AddressModel addressModel)
        {
            var address = await _addressRepository.GetByIdAsync(addressModel.Id);
            if (address == null)
            {
                throw new Exception("Cep não encontrado");
            }
            address = AddressAdapter.MapForEntityToUpdate(addressModel);
            return await _addressRepository.UpdateDataAsync(address);
        }
    }
}
