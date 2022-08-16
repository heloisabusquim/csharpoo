using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharpoo.Delivery
{
    public class Produto
    {
        public int codigoCombo { get; set; }
        public string descricao { get; set; }
        public double valorUnitario { get; set; }
        public int quantidadeEstoque { get; set; }

        public Produto(int codigoCombo, string descricao, double valorUnitario, int quantidadeEstoque)
        {
            this.codigoCombo = codigoCombo;
            this.descricao = descricao;
            this.valorUnitario = valorUnitario;
            this.quantidadeEstoque = quantidadeEstoque;   
        }
    }
    

}