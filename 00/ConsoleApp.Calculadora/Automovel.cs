using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Calculadora
{
    //abstract, nao pode ser instanciada
    //somente heradada
    public abstract class Automovel
    {
        private int velocidade;

        public void Acelerar(int veloce)
        {
            velocidade = 10;
        }


        //somente acessado pela classe base
        protected void InjecaoEletronica()
        {

        }

        //nao possui implementacao
        //quem heradar a classe deve implementar este metodo
        protected abstract void LigarVeiculo();

        //quem herdar esta classe "pode" mudar implementacao
        public virtual void DesligarVeiculo()
        {
            //calculos magicos muito legals
        }
    }

    //para herdar deve-se utilizar : depois o nome da classe
    public class Caminhao : Automovel
    {
        //override para mudar implementacao
        public override void DesligarVeiculo()
        {
            //puxar manivela

            base.DesligarVeiculo();
        }

        public void AcelerarCaminhao()
        {

        }

        protected override void LigarVeiculo()
        {
            throw new NotImplementedException();
        }
    }
}
