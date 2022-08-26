using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OO.ByteBank.titular.cliente
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

        public override bool Equals(Object obj)
        {
            Cliente convertendoObjetoEmCliente = obj as Cliente;

            if(convertendoObjetoEmCliente == null)
            {
                return false;
            }
            return cpf == convertendoObjetoEmCliente.cpf;
        }

        public static int TotalClientesCadastrados { get; set; }
    }

    
}