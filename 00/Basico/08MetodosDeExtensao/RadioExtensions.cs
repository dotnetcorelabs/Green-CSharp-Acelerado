using System;
using System.Collections.Generic;
using System.Text;

namespace Basico._08MetodosDeExtensao
{
    public static class RadioExtensions
    {
        public static void AumentarVolume(this Radio radio, int novoVolume)
        {
            radio.Volume = novoVolume;
        }
    }
}
