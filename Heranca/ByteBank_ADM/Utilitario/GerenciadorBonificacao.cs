using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heranca.ByteBank_ADM.Funcionarios;

namespace Heranca.ByteBank_ADM.Utilitario
{
    public class GerenciadorBonificacao
    {
        private double totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return this.totalBonificacao;
        }
    }
}