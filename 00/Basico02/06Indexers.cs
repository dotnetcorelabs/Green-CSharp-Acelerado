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
}
