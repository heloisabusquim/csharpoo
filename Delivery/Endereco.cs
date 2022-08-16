using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharpoo.Delivery
{
    public class Endereco
    {
        public string rua { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; } = "";
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string cep { get; set; }

        public Endereco(string rua, string numero, string complemento, string bairro, string cidade, string cep)
        {
            this.rua = rua;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.cep = cep;
            
        }

    }
}