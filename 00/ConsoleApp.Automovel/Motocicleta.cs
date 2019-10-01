using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Automovel
{
    public class Motocicleta : Automovel
    {
        public override void Acelerar(int aceleracao)
        {
            SetVelocidadeAtual(GetVelocidadeAtual() + aceleracao + 2);
        }
    }
}
