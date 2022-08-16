using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public string titular {get; set;}
        public string numero_conta {get; set;}
        public int numero_agencia {get; set;}
        public string nome_agencia {get; set;}
        public double saldo {get; set;}

        public ContaCorrente(string titular, string numero_conta, int numero_agencia, string nome_agencia, double saldo)
        {
            this.titular = titular;
            this.numero_conta = numero_conta;
            this.numero_agencia = numero_agencia;
            this.nome_agencia = nome_agencia;
            this.saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if (saldo < valor)
            {
                Console.WriteLine("Saque não realizado. Saldo insuficiente!");
                // Console.WriteLine("O valor a sacar é de: " + valor + ", porém o seu saldo atual é de: " + saldo);
            }
            else
            {
                saldo -= valor;
                // Console.WriteLine("Saque realizado com sucesso da conta: " + numero_conta + ". Seu saldo atual é de: " + saldo);
            }
        }

        public void Depositar(double valor)
        {
            saldo +=valor;
            Console.WriteLine("Depósito realizado com sucesso!");
        }

        public void Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                Console.WriteLine("Transferência não realizada. Saldo insuficiente!");
                // Console.WriteLine("O valor a transferir é de: " + valor + ", porém o seu saldo é de: " + saldo);
            }
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                // Console.WriteLine("Transferência realizada com sucesso da conta: " + numero_conta + " para a conta " + destino.numero_conta + ". Seu saldo atual é de: " + saldo);

            }
        }

    }
}