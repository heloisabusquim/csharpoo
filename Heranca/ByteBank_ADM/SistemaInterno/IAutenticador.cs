using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heranca.ByteBank_ADM.Funcionarios;

namespace Heranca.ByteBank_ADM.SistemaInterno
{
    public interface IAutenticador
    {
        public bool Autenticar(string user, string senha);
    }
}