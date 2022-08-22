using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class Diretor: Funcionario
    {
        public override double GetBonificacao()
        {
            return salario + base.GetBonificacao();
        }
    }
}