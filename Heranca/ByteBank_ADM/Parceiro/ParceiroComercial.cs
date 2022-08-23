using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heranca.ByteBank_ADM.SistemaInterno;

namespace Heranca.ByteBank_ADM.Parceiro
{
    public class ParceiroComercial : IAutenticador
    {
        public string User { get; set; }
        public string Senha { get; set; }
        public bool Autenticar(string user, string senha)
        {
            return (this.User == user && this.Senha == senha);
        }
    }
}