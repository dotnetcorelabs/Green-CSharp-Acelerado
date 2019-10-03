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

        public void LoopForeach()
        {
            string[] nome = new string[] { "Ricardo", "Ricardo2", "Ricardo3" };
            foreach (var n in nome)
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
