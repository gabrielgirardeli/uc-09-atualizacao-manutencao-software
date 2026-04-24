using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainPetshop.Entities
{
    namespace Domain.Entities
    {
        public class Contato
        {
            public int Id { get; set; }
            public string Nome { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string Mensagem { get; set; } = string.Empty;

            [Column("data_envio")]
            public DateTime DataEnvio { get; set; }
        }
    }
}
