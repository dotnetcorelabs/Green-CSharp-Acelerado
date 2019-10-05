using Basico02;
using System;
using Xunit;

namespace Basico002.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Coffee coffe = new Coffee();
            coffe.OnCafeRecebido += Coffe_OnCafeRecebido;

            coffe.AbastecerCafe(100);

            Assert.NotNull(coffe);
        }

        private void Coffe_OnCafeRecebido(Coffee coffe, EventArgs args)
        {
        }
    }
}
