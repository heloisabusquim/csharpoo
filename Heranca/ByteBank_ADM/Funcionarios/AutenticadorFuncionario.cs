using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heranca.ByteBank_ADM.Funcionarios;
using Heranca.ByteBank_ADM.SistemaInterno;

namespace Heranca.ByteBank_ADM.Funcionarios
{
    public abstract class AutenticadorFuncionario : Funcionario, IAutenticador
    {
        protected AutenticadorFuncionario(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public string User { get; set; }
        public string Senha { get; set; }

        public bool Autenticar(string user, string senha)
        {
            return (this.User == user && this.Senha == senha);
        }
    }
}