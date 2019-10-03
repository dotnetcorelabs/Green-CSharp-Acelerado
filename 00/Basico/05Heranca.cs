using System;
using System.Collections.Generic;
using System.Text;

namespace Basico
{
    //Exemplo de heranca
    //classe abstrata nao pode ser instanciada diretamente
    //para utiliza-la deve-se ter uma classe que herde dela
    public abstract class Animal
    {
        public string DNA { get; set; }

        public abstract void Mutacao();

        public virtual void Andar()
        {
            //implementacao de andar
        }
    }

    //classe que herda de Animal (classe abstrata)
    public class Humano : Animal
    {
        public override void Mutacao()
        {
            //implementacao de mutacao
        }

        public override void Andar()
        {
            //nova implementacao de andar
            base.Andar();
        }
    }
}
