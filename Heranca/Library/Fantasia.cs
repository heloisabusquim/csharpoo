using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.Library
{
    public class Fantasia: Livro
    {
        public Fantasia(string titulo, string autor, string isbn): base(titulo, autor, isbn)
        {
            Console.WriteLine("Registrando livro...");
        }

        public override void FichaLivro()
        {
            if(this.anoPublicacao == 0 || this.numeroPaginas == 0)
            {
            Console.WriteLine("FICHA DO LIVRO \nTítulo: " + this.titulo + 
            " | Autor: " + this.autor +
            "\nISBN: " + this.isbn);
            Console.WriteLine("*****************************************");
            }
            else
            {
            Console.WriteLine("FICHA DO LIVRO \nTítulo: " + this.titulo + 
            " | Autor: " + this.autor + 
            "\nAno de Publicação: " + this.anoPublicacao + 
            " | Número de Páginas: " + this.numeroPaginas + 
            "\nISBN: " + this.isbn);
            Console.WriteLine("*****************************************");
            }
        }
    }
}