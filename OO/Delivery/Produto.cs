using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OO.Delivery
{
    public class Produto
    {
        public int codigoCombo { get; set; }
        public int quantidadeSolicitada { get; set;}
        public string? descricao { get; set; }
        public double valorUnitario { get; set; }

        public Produto(int codigoCombo)
        {
            this.codigoCombo = codigoCombo;
        }

        public void InfoCombos()
        {
            if(this.codigoCombo == 1)
            {
                valorUnitario = 50.00;
                descricao = "Pizza grande + refrigerante";
                Console.WriteLine("ITEM: " + descricao + "| QUANTIDADE: " + this.quantidadeSolicitada + "\nTOTAL: R$ " + this.quantidadeSolicitada*this.valorUnitario);
            }
            else if (this.codigoCombo == 2)
            {
                valorUnitario = 30.00;
                descricao = "Pastel + caldo de cana";
                Console.WriteLine("ITEM: " + descricao + "| QUANTIDADE: " + this.quantidadeSolicitada + "\nTOTAL: R$ " + this.quantidadeSolicitada*this.valorUnitario);
            }
            else
            {
                valorUnitario = 45.00;
                descricao = "Bolo de cenoura + café expresso";
                Console.WriteLine("ITEM: " + descricao + "| QUANTIDADE: " + this.quantidadeSolicitada + "\nTOTAL: R$ " + this.quantidadeSolicitada*this.valorUnitario);
            }
        }
    }
    

}