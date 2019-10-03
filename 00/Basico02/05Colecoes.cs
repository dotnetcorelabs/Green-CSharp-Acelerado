using System;
using System.Collections.Generic;
using System.Text;

namespace Basico02
{
    class _05Colecoes
    {
        #region List
        private List<string> list = new List<string>();

        public void AddList(string nome)
        {
            list.Add(nome);
        }
        #endregion List

        #region Array
        private string[] array = new string[3];
        public void AddArray(string nome, int posicao)
        {
            array[posicao] = nome;
        }
        #endregion Array

        #region Dicionario
        private Dictionary<string, int> dicionario = new Dictionary<string, int>();

        public void AddDicionario(string chave, int valor)
        {
            dicionario.Add(chave, valor);
        }
        #endregion Dicionario

        #region Stack
        private Stack<string> stack = new Stack<string>();

        public void AddStack(string nome)
        {
            stack.Push(nome);
        }
        public string RemoveStack()
        {
            return stack.Pop();
        }
        #endregion Stack

        
    }
}
