using System;
using System.Collections.Generic;
using System.Text;

namespace Basico
{
    public class _11Condicional
    {
        public void CondicionalIf()
        {
            string nome = "Ricardo";

            if (nome == "Ricardo")
            {
                //caso positivo
            }
            else
            {
                //caso negativo
            }
        }

        public void LoopFor()
        {
            string[] nome = new string[] { "Ricardo", "Ricardo2", "Ricardo3" };
            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine(nome[i]);
            }
        }

        void LoopRemovendo()
        {
            List<string> nomeList = new List<string>()
            {
                "nome1",
                "nome2",
                "nome3"
            };
            for (int i = nomeList.Count - 1; i >= 0; i--)
            {
                nomeList.RemoveAt(i);
            }
        }

        public void LoopForeach()
        {
            string[] nomes = new string[] { "Ricardo", "Ricardo2", "Ricardo3" };
            foreach (string n in nomes)
            {
                Console.WriteLine(n);
            }
        }

        public void LoopWhile()
        {
            string[] nome = new string[] { "Ricardo", "Ricardo2", "Ricardo3" };
            int index = 0;

            while (nome.Length < index)
            {
                Console.WriteLine(nome[index]);
                index++;
            }
        }

        public void LoopDoWhile()
        {
            string[] nome = new string[] { "Ricardo", "Ricardo2", "Ricardo3" };
            int index = 0;

            do
            {
                Console.WriteLine(nome[index]);
                index++;
            } while (nome.Length < index);
        }
    }
}
