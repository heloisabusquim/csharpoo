using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharpoo.Delivery
{
    public class Cliente
    {
        public string nomeCompleto { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public Endereco endereco { get; set; }

        public Cliente(string nomeCompleto, string cpf, string email, string telefone)
        {
            this.nomeCompleto = nomeCompleto;
            this.cpf = cpf;
            this.email = email;
            this.telefone = telefone;
            
        }
    }
}