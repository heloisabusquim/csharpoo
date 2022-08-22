using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//EXERCÍCIO EXTRA - Classe abstrata + Herança

namespace Heranca.Library
{
    public abstract class Livro
    {
        public string titulo { get; private set; }
        public string autor { get; private set; }
        public string isbn { get; private set; }
        public int anoPublicacao { get; set; }
        public int numeroPaginas { get; set; }

        public Livro(string titulo, string autor, string isbn)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.isbn = isbn;
            TotalLivrosRegistrados++;
        }

        public abstract void FichaLivro();
        
        public static int TotalLivrosRegistrados {get; set;}
    }

}