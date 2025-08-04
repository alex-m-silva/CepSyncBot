using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        public string? Logadouro { get; set; }
        public string? CEP { get; set; }
        public string? Bairro { get; set; }
        public string? UF { get; set; }
    }
}
