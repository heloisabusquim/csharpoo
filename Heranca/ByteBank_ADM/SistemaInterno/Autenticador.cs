using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heranca.ByteBank_ADM.Funcionarios;

namespace Heranca.ByteBank_ADM.SistemaInterno
{
    public abstract class Autenticador : Funcionario
    {
        public Autenticador(string nome, string cpf, double salario) : base(nome, cpf, salario)
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