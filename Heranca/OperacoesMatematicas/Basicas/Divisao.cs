using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.OperacoesMatematicas.Basicas
{
    public class Divisao
    {
        public double Calcular(double valor1, double valor2)
        {
            if(valor2 == 0)
            {
                return 0;
            }
            else
            {
                return valor1 / valor2;
            }
        }
    }
}