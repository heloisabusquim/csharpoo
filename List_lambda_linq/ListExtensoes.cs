using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharpoo.List_lambda_linq
{
    public static class ListExtensoes
    {

        public static void AdicionarVarios(this List<int> listaDeInteiros, params int[] itens)
        {
            foreach(int item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }

    }

}