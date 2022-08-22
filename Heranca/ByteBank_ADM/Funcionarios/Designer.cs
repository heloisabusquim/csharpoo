using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.ByteBank_ADM.Funcionarios
{
    public class Designer: Funcionario
    {
        public Designer(string nome, string cpf): base(nome, cpf, 3000.00)
        {

        }

        public override double GetBonificacao()
        {
            return salario * 0.17;
        }

        public override double AumentarSalario()
        {
            return this.salario += 1.11;
        }
    }
}