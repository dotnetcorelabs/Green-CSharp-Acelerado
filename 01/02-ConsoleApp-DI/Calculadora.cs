using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DI
{
    public class Calculadora
    {
        private readonly ILogger<Calculadora> logger;

        public Calculadora(ILogger<Calculadora> logger)
        {
            this.logger = logger;
        }

        public decimal Somar(decimal valor, decimal valor2)
        {
            return valor + valor2;
        }

        public decimal Subtrair(decimal valor, decimal valor2)
        {
            return valor + valor2;
        }
    }
}
