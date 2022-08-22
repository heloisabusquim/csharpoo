using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.ByteBank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string nome { get; private set; }
        public string cpf { get; private set; }
        public double salario { get; protected set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.salario = salario;
            TotalFuncionarios++;
        }
        
        public abstract double GetBonificacao();

        public abstract double AumentarSalario();

        public static int TotalFuncionarios {get; private set;}
    
    }
}