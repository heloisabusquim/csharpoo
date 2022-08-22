using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OperacoesMatematicas.Basicas;

namespace OperacoesMatematicas.Utilitario
{
    public class Operacoes
    {
        public Soma somar { get; set; }
        public Subtracao subtrair { get; set; }
        public Multiplicacao multiplicar { get; set; }
        public Divisao dividir { get; set; }

        public Operacoes()
        {
            this.somar = new Soma();
            this.subtrair = new Subtracao();
            this.multiplicar = new Multiplicacao();
            this.dividir = new Divisao();
        }
    }
}