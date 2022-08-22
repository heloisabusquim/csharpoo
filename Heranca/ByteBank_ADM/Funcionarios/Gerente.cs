using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.ByteBank_ADM.Funcionarios
{
    public class Gerente: Funcionario
    {
        public Gerente(string nome, string cpf): base(nome, cpf, 4000.00)
        {

        }

        public override double GetBonificacao()
        {
            return salario * 0.25;
        }

        public override double AumentarSalario()
        {
            return this.salario += 1.5;
        }
    }
}