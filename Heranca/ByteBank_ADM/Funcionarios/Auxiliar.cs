using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.ByteBank_ADM.Funcionarios
{
    public class Auxiliar: Funcionario
    {
        public Auxiliar(string nome, string cpf): base(nome, cpf, 2000.00)
        {

        }

        public override double GetBonificacao()
        {
            return salario * 0.20;
        }

        public override double AumentarSalario()
        {
            return this.salario += 1.10;
        }
    }
}