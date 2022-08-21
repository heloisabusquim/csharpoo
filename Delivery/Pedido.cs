using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery
{
    public class Pedido
    {
        public int numeroComanda { get; set ;} = 0;
        public Contato? cliente { get; set; }
        public Produto? item { get; set; }
        public Produto? quantidadeSolicitada { get; set; }

        //IMPROVEMENT: Criar um método que gere números de comanda sequencial e sem repetir.

    }

}