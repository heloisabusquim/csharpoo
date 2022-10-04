using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OO.ByteBank;

namespace csharpoo.List_lambda_linq
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente? x, ContaCorrente? y)
        {
            if (x == y)
            {
                return 0;
            }

            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }

            return x.numeroAgencia.CompareTo(y.numeroAgencia);

            //esse return x.numeroAgencia.CompareTo(y.numeroAgencia) por baixo dos panos, faz isso:
            
            // if(x.numeroAgencia < y.numeroAgencia)
            // {
            //     return -1;
            // }

            // if(x.numeroAgencia == y.numeroAgencia)
            // {
            //     return 0;
            // }

            // return 1;
        }
    }
}