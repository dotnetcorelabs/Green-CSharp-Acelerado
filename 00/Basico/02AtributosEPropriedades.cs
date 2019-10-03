using System;
using System.Collections.Generic;
using System.Text;

namespace Basico
{
    public class Automovel
    {
        //atributo privado (somente a classe)
        private int velocidadeAtual;

        //atributo publico (todos)
        public string placa;

        //atributo protected (somente classe e heranca)
        protected string chassi;


        /// <summary>
        /// Auto propriedade
        /// Em tempo de compilacao sera gerado um
        /// atributo para essa propriedade
        /// 
        /// Similar aos getters and setters do java
        /// </summary>
        public int Velocidade { get; set; }

        /// <summary>
        /// Propriedade com get e set utilizando atributo declarado 
        /// acima (velocidadeAtual)
        /// </summary>
        public int VelocidadeAtual
        {
            get { return velocidadeAtual; }
            set 
            {
                //validando se valor negativo
                if(value < 0)
                {
                    velocidadeAtual = 0;
                }
                else
                {
                    velocidadeAtual = value;
                }
            }
        }

        /// <summary>
        /// Auto propriedade com modificador de acesso protected
        /// </summary>
        protected int VelocidadeProtected { get; set; }

        /// <summary>
        /// Auto Propriedade com modificador de acesso private
        /// </summary>
        private int VelocidadePrivate { get; set; }
    }
}
