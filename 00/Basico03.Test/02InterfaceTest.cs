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
            ICarro veiculo = new FordKa();
            veiculo.Andar();

            Assert.NotNull(veiculo);

            Assert.IsAssignableFrom<IVeiculo>(veiculo);
        }
    }
}
