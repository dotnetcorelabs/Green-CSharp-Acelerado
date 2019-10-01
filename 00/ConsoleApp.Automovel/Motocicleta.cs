using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Automovel
{
    public class Motocicleta : Automovel
    {
        protected override void Acelerar(int aceleracao)
        {
            SetVelocidadeAtual(GetVelocidadeAtual() + aceleracao + 2);
        }
    }
}
