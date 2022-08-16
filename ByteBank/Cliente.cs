using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.titular
{
    public class Cliente
    {
        public string nome { get; set; }
        public string cpf { get; set; }

        public Cliente(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
            TotalClientesCadastrados++;
        }

        public static int TotalClientesCadastrados { get; set; }
    }

    
}