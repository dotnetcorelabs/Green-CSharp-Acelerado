using System;
using System.Collections.Generic;
using System.Text;

namespace Basico._08MetodosDeExtensao
{
    public class SalaDeEstar
    {
        public Radio Radio { get; set; }

        public SalaDeEstar()
        {
            Radio = new Radio();
            //utilizando metodo de extensao
            Radio.AumentarVolume(10);
        }
    }
}
