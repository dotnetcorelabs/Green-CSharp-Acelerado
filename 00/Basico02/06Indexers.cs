using System;
using System.Collections.Generic;
using System.Text;

namespace Basico02
{
    public class _06Indexers
    {
        private readonly List<string> nomes = new List<string>()
        {
            "nome1",
            "nome2",
            "nome3",
        };

        public string this[int index]
        {
            get
            {
                if (index < nomes.Count)
                    return nomes[index];

                return string.Empty;
            }
        }
    }

    public class Indexer2
    {
        private int idade = 10;
        private int idade2 = 22;
        private int idade3 = 33;

        public int this[string nomePessoa]
        {
            get
            {
                if(nomePessoa == "nome1")
                {
                    return idade;
                }
                else if(nomePessoa == "nome2")
                {
                    return idade2;
                }
                else if(nomePessoa == "nome3")
                {
                    return idade3;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("nomePessoa");
                }
            }
        }
    }
}
