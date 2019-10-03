using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Exemplo 2 - Métodos
/// </summary>
namespace Basico
{
    public class Veiculo
    {
        //public - modificador de acesso
        //void - tipo de retorno void (nenhum retorno)
        //Ligar - nome do método (em C# é camel case com primeiro letra sempre maiuscula
        public void Ligar()
        {

        }

        //public - modificador de acesso
        //int - tipo de retorno int 
        //Acelerar - nome do método (em C# é camel case com primeiro letra sempre maiuscula
        //int aceleracao - argumento do metodo
        public int Acelerar(int aceleracao)
        {
            return aceleracao;
        }

        //protected - modificador de acesso
        //int - tipo de retorno int 
        //AcelerarProtected - nome do método (em C# é camel case com primeiro letra sempre maiuscula
        //int aceleracao - argumento do metodo
        protected int AcelerarProtected(int aceleracao)
        {
            return aceleracao;
        }
    }
}
