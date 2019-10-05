using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Basico02
{
    class _05Colecoes
    {
        #region ArrayList
        private ArrayList arrayList = new ArrayList();
        public void AddArrayList()
        {
            arrayList.Add("fefefe");
            arrayList.Add(11);

            string nome = (string)arrayList[0];
            int number = (int)arrayList[1];
        }
        #endregion ArrayList

        #region List
        private List<string> list = new List<string>();
        private List<string> listNome = new List<string>()
        {
            "nome 1",
            "nome 2"
        };

        private Collection<string> collection = new Collection<string>();

        public void AddList(string nome)
        {
            list.Add(nome);

            string primeiroNome = list[0];
            string segundoNome = list[1];

            //list.Where(x => x == "nome").First();
        }
        #endregion List

        #region Array
        private string[] nomes = new string[]
        {
            "ricardo",
            "ricardo2",
            "nome 3"
        };

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

            dicionario.Add("chave1", 10);
            //dicionario.Add("chave1", 12);

            dicionario.Add("chave2", 13);

            int valorDaChave1 = dicionario["chave1"];

            //throw exception
            int valorChaveNaoExiste = dicionario["kekekek"];

            if (dicionario.ContainsKey("kekekek"))
            {
                int c = dicionario["kekekek"];
            }
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
