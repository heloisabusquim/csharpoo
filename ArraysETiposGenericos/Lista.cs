using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharpoo.ArraysETiposGenericos
{
    public class Lista<T>
    {
        private T[] _itens;
        private int _proximaPosicao;

        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }

        public Lista(int capacidadeInicial = 5)
        {
            _itens = new T[capacidadeInicial];
            _proximaPosicao = 0;

        }

        public void Adicionar(T item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;

            Console.WriteLine($"Conta salva");
        }

        public void Remover(T item)
        {
            int indiceItem = -1;

            for(int i = 0; i < _proximaPosicao; i++)
            {
                T itemAtual = _itens[i];

                if(itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            for(int i = indiceItem; i < _proximaPosicao-1; i++)
            {
                _itens[i] = _itens[i+1];
            }

            _proximaPosicao--;
            // _itens[_proximaPosicao] = null;
            
            Console.WriteLine($"Conta removida");
        }

        public T GetItemNoIndice(int indice)
        {
            if(indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }

        public T this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if(_itens.Length >= tamanhoNecessario)
            {
                return;
            }
            int novoTamanho = _itens.Length * 2;
            if(novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            T[] novoArray = new T[novoTamanho];

            for(int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
            }
            _itens = novoArray;
        }
    }
}