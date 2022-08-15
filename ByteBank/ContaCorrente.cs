using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public string titular {get; set;} = "";
        public string numero_conta {get; set;} = "";
        public int numero_agencia {get; set;}
        public string nome_agencia {get; set;} = "";
        public double saldo {get; set;}


    }
}