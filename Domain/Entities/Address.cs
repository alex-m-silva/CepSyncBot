using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string? Logadouro { get; set; }
        public string? CEP{ get; set; }
        public string? Bairro { get; set; }
        public string? UF { get; set; }
        public EnumStatus Status { get; set; } = EnumStatus.Aberto;
        public string? Robo { get; set; }
    }
}
