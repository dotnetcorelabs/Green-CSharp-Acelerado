using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Basico03.Test
{
    public class InterfaceTest
    {
        [Fact]
        public void TestInterface()
        {
            BMW carroBMW = new BMW();
            carroBMW.CoisaEspertaBMW = 10;
            carroBMW.Andar();

            ICarro veiculo = new BMW();
            veiculo.Andar();
            

            Assert.NotNull(veiculo);

            Assert.IsAssignableFrom<IVeiculo>(veiculo);
        }
    }
}
