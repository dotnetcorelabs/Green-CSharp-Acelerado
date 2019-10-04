using System;
using System.Collections.Generic;
using System.Text;

namespace Basico
{
    public class Estaticos01
    {
        int velocidadeAtual = 0;

        //Metodo NAO estatico
        public void Andar()
        {
            velocidadeAtual = 10;
        }

        //Metodo estatico
        //Nao utiliza o objeto
        //nao tem acesso ao atributo velocidadeAtual
        static void AndarEstatico()
        {

        }
    }

    class AcessoADados
    {
        //codigo magico de acesso a dados

        private AcessoADados()
        { }

        static AcessoADados _instacia;

        public static AcessoADados GetInstancia()
        {
            if (_instacia == null)
                _instacia = new AcessoADados();

            return _instacia;
        }
    }
}
