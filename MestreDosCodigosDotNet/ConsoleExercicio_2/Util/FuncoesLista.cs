using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleExercicio_2.Util
{
    public class FuncoesLista<T> where T : IComparable
    {
        private List<T> _listaItens;
        public FuncoesLista(List<T> lista)
        {
            _listaItens = lista;
            ValidarLista();
        }

        private void ValidarLista()
        {
            if (!_listaItens.Any())
                throw new Exception("ERRO. A lsita esta vazia");
        }

        public T PegarMenorItemFor()
        {
            T menorItem = _listaItens.First();
            for (int i = 0; i < _listaItens.Count; i++)
                menorItem = PegarMenorItem(menorItem, _listaItens[i]);

            return menorItem;
        }

        public T PegarMaiorItemFor()
        {
            T maiorItem = _listaItens.First();
            for (int i = 0; i < _listaItens.Count; i++)
                maiorItem = PegarMaiorItem(maiorItem, _listaItens[i]);

            return maiorItem;
        }

        public T PegarMenorItemWhile()
        {
            T menorItem = _listaItens.First();
            int i = 0;
            while (i < _listaItens.Count)
            {
                menorItem = PegarMenorItem(menorItem, _listaItens[i]);
                i++;
            }

            return menorItem;
        }

        public T PegarMaiorItemWhile()
        {
            T maiorItem = _listaItens.First();
            int i = 0;
            while (i < _listaItens.Count)
            {
                maiorItem = PegarMaiorItem(maiorItem, _listaItens[i]);
                i++;
            }

            return maiorItem;
        }

        private T PegarMenorItem(T item1, T item2)
        {
            return (item1.CompareTo(item2) > 0 ? item2 : item1);
        }

        private T PegarMaiorItem(T item1, T item2)
        {
            return (item1.CompareTo(item2) < 0 ? item2 : item1);
        }


    }
}
