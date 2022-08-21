using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.titular.cliente;

namespace ByteBank
{
    public class ContaCorrente
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
        public void InformacoesConta()
            {
                Console.WriteLine("Agência: " + this.numeroAgencia + " (" + this.nomeAgencia + ")" + " | Conta: " + this.numeroConta);
                Console.WriteLine("Titular: " + this.titular.nome + " | CPF: " + this.titular.cpf);
                Console.WriteLine("Saldo atual: " + this.saldo);
            }

        public static int TotalContasCriadas {get; set;}
    }
}