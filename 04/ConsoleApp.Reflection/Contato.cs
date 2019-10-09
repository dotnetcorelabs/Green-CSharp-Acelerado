using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Reflection
{
    [Serializable]
    public class Contato
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }
    }
}
