using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Reflection
{
    public interface IPagamento
    {
        void Pagar(string produtoId, decimal valor);
    }
}
