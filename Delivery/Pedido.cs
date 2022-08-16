using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharpoo.Delivery
{
    public class Pedido
    {
        public int numeroPedido { get; set ;}
        public Cliente cliente { get; set; }
        public ItemPedido item { get; set; }
        public double totalPedido { get; set; }
    }
}