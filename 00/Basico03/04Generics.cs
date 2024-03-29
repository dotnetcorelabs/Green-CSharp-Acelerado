﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basico03
{
    public class CustomList<T>
    {
        private readonly List<T> internalList = new List<T>();

        public T this[int index]
        {
            get { return internalList[index]; }
            set { internalList[index] = value; }
        }

        public void Add(T item)
        {
            // Method logic goes here.
            internalList.Add(item);
        }


        public void Remove(T item)
        {
            // Method logic goes here.
            internalList.Remove(item);
        }
    }


    /// <summary>
    /// list de veiculos ou derivados
    /// Referencia: https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/where-generic-type-constraint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SuperCarro<T>
        where T : class, IVeiculo, new()
    {
        public T Item { get; private set; }

        public void Adicionar(T @value)
        {
            Item = @value;
        }

        public IVeiculo CriarInstancia()
        {
            T instancia = new T();
            return instancia;
        }

        public void AndarComTurbo()
        {
            Item.Andar();
            Item.Andar();
            Item.Andar();
        }
    }
}
