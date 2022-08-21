using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery
{
    public class Descricao
    {
        public string texto { get; set; }

        public Descricao(string texto)
        {
            this.texto = texto;
        }
    }
}