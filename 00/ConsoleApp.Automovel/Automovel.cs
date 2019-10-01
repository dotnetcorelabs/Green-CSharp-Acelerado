using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Automovel
{
    public abstract class Automovel
    {
        private int velocidade;

        protected virtual void Acelerar(int aceleracao)
        {
            int novaVelocidade = GetVelocidadeAtual() + aceleracao;
            SetVelocidadeAtual(novaVelocidade);
        }

        public int GetVelocidadeAtual()
        {
            return velocidade;
        }

        public void SetVelocidadeAtual(int novaVelocidade)
        {
            velocidade = novaVelocidade;
        }
    }
}
