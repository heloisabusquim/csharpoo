using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperacoesMatematicas.Basicas
{
    public class Multiplicacao
    {
        public double Calcular(double valor1, double valor2)
        {
            if(valor1 == 0 || valor2 == 0)
            {
                return 0;
            }
            else
            {
                return valor1 * valor2;
            }
        }
    }
}