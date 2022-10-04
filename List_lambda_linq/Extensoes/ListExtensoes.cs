using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharpoo.List_lambda_linq
{
    public static class ListExtensoes
    {

        public static void AdicionarVarios<T>(this List<T> listaDeInteiros, params T[] itens)
        {
            foreach(T item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }

    }

}