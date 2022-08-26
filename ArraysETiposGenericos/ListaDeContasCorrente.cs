using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OO.ByteBank;

namespace csharpoo.ArraysETiposGenericos
{
    public class ListaDeContasCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        public ListaDeContasCorrente()
        {
            _itens = new ContaCorrente[5];
            _proximaPosicao = 0;

        }

        public void Adicionar(ContaCorrente item)
        {
            VerificarCapacidade(_proximaPosicao + 1);
            
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if(_itens.Length >= tamanhoNecessario)
            {
                return;
            }
            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

            for(int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
            }
            _itens = novoArray;
        }
    }
}