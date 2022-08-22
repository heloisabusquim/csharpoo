using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OO.Delivery
{
    public class Contato
    {
        public string nomeCompleto { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public Endereco? endereco { get; set; }

        public Contato(string nomeCompleto, string cpf, string telefone)
        {
            this.nomeCompleto = nomeCompleto;
            this.cpf = cpf;
            this.telefone = telefone;
            
        }

        public void DadosCliente()
        {
            Console.WriteLine("CLIENTE: " + nomeCompleto + " | CPF: " + cpf + " | Telefone: " + telefone);
        }
    }
}