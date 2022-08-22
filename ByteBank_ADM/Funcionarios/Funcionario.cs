using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string? nome { get; set; }
        public string? cpf { get; set; }
        public double salario { get; set; }

        public virtual double GetBonificacao()
        {
                return salario * 0.10;
        }
    }
}