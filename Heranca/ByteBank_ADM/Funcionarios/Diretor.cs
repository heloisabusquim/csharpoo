using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heranca.ByteBank_ADM.SistemaInterno;

namespace Heranca.ByteBank_ADM.Funcionarios
{
    public class Diretor: AutenticadorFuncionario
    {
        public Diretor(string nome, string cpf): base(nome, cpf, 5000.00)
        {

        }
        public override double GetBonificacao()
        {
            return salario * 0.50;
        }

        public override double AumentarSalario()
        {
            return this.salario *= 1.15;
        }
    }
}