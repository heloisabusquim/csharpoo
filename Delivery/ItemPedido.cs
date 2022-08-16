using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharpoo.Delivery
{
    public class ItemPedido
    {
        public int quantidade { get; set; }
        public int numeroPedido { get; set; }
        public Produto comboUm { get; set; }
        public Produto comboDois { get; set; }
        public Produto comboTres { get; set; }

        public ItemPedido(int quantidade, int numeroPedido)
        {
            this.quantidade = quantidade;
            this.numeroPedido = numeroPedido;
        }
    }
}