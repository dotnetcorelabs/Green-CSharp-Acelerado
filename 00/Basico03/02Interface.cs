using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basico03
{
    /// <summary>
    /// Define somente o contrato. O que a classe ou struct que vai implementar deve ter
    /// "Nao possui" implementacao
    /// Referencia: https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/interface
    /// </summary>
    public interface IVeiculo
    {
        void Andar();
    }

    public interface ICarro : IVeiculo
    {
        void Estacionar();
    }

    public class FordKa : ICarro
    {
        //Necessario implmenetar interface
        public void Andar()
        {
            //alguma implementacao
        }

        public void Estacionar()
        {
            //alguma implementacao
        }
    }
}
