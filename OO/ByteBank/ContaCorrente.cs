using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OO.ByteBank.titular.cliente;

namespace OO.ByteBank
{
    public class ContaCorrente : IComparable
    {
        public Cliente titular {get; set;}
        public string numeroConta {get; set;}
        public int numeroAgencia {get; set;}
        public string nomeAgencia {get; set;}
        public double saldo {get; set;}

        public ContaCorrente(int numeroAgencia, string numeroConta, string nomeAgencia)
        {
            this.numeroAgencia = numeroAgencia;
            this.numeroConta = numeroConta;
            this.nomeAgencia = nomeAgencia;
            TotalContasCriadas++;
        }

        public void Sacar(double valor)
        {
            if (saldo < valor)
            {
                Console.WriteLine("Saque não realizado. Saldo insuficiente na conta: " + numeroConta + "! Seu saldo atual é de: " + saldo);
            }
            else
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso na conta: " + numeroConta + "!. Seu saldo atual é de: " + saldo);
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso na conta: " + numeroConta + "!");
            Console.WriteLine("O saldo atual é de: " + saldo);
        }

        public void Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                Console.WriteLine("Transferência não realizada. Saldo insuficiente na conta: " + numeroConta + "! Seu saldo atual é de: " + saldo);
            }
            else
            {
                this.Sacar(valor);
                destino.saldo += valor;
                Console.WriteLine("Transferência realizada com sucesso na conta: " + numeroConta + "! Seu saldo atual é de: " + saldo);
            }
        }

        //desafio: criar método que mostra todas as informações da conta na tela
        //Improvement: interpolação com ToString
        // public void InformacoesConta()
        //     {
        //         Console.WriteLine("Agência: " + this.numeroAgencia + " (" + this.nomeAgencia + ")" + " | Conta: " + this.numeroConta);
        //         Console.WriteLine("Titular: " + this.titular.nome + " | CPF: " + this.titular.cpf);
        //         Console.WriteLine("Saldo atual: " + this.saldo);
        //     }

        public override string ToString()
        {
            return $"Agência: {this.numeroAgencia} ({this.nomeAgencia}) | Conta: {this.numeroConta}\nTitular: {this.titular.nome} | CPF: {this.titular.cpf}\nSaldo atual: {this.saldo}";
        }

        public override bool Equals(object obj)
        {
            ContaCorrente outraConta = obj as ContaCorrente;

            if(outraConta == null)
            {
                return false;
            }
            return numeroConta == outraConta.numeroConta && numeroAgencia == outraConta.numeroAgencia && nomeAgencia == outraConta.nomeAgencia;
        }

        public int CompareTo(object? obj)
        {
            var outraConta = obj as ContaCorrente;

            if(numeroAgencia < outraConta.numeroAgencia)
            {
                return -1;
            }

            if(numeroAgencia == outraConta.numeroAgencia)
            {
                return 0;
            }

            return 1;
        }

        public static int TotalContasCriadas {get; set;}

    }
}