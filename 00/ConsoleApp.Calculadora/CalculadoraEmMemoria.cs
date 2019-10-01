using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Calculadora
{
    //classe
    public class Calculadora
    {
        //somente consegue ser utilizado dentro da heranca
        protected decimal CalculaDiametro(int valor)
        {
            return decimal.Parse(valor.ToString());
        }

        //acesso publico de fora da classe
        public decimal Ricardo()
        {
            return 0m;
        }
    }

    public class CalculadoraEmMemoria : Calculadora
    {
        public decimal DiametroNovo()
        {
            Ricardo();
            return CalculaDiametro(19);
        }

        public int Somar(int operador1, int operador2)
        {
            int resultadoSoma = SomarPrivado(operador1, operador2);
            return resultadoSoma;
        }


        private int SomarPrivado(int operador1, int operador2)
        {
            return operador1 + operador2;
        }

        int SomarPrivadoImplicito(int operador1, int operador2)
        {
            return operador1 + operador2;
        }

        protected int SomarProtected(int operador1, int operador2)
        {
            return operador1 + operador2;
        }
    }
}
