using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Adapters
{
    public static class AddressAdapter
    {
        public static AddressModel MapForModel(Address address)
        {
            AddressModel addressModel = new AddressModel
            {
                Id = address.Id,
                CEP = address.CEP,
                Logadouro = address.Logadouro,
                UF = address.UF
            };
            return addressModel;
        }

        public static Address MapForEntity(AddressModel addressModel)
        {
            Address address = new Address
            {
                Id = addressModel.Id,
                CEP = addressModel.CEP,
                Logadouro = addressModel.Logadouro,
                UF = addressModel.UF
            };
            return address;
        }

        public static Address MapForEntityToUpdate(AddressModel addressModel)
        {
            Address address = new Address
            {
                Logadouro = addressModel.Logadouro,
                Bairro = addressModel.Bairro,
                UF = addressModel.UF,
                Status = Domain.Enums.EnumStatus.Finalizado
            };
            return address;
        }

        public static List<AddressModel> MapForModelList(List<Address> addresses)
        {
            return addresses.Select(MapForModel).ToList();
        }

        public static List<Address> MapForEntityList(List<AddressModel> addressesModel)
        {
            return addressesModel.Select(MapForEntity).ToList();
        }
    }
}
