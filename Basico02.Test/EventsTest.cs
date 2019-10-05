using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basico02.Test
{
    public class EventsTest
    {
        [Test]
        public void EventTest()
        {
            Coffee coffe = new Coffee();

            coffe.AcabouOCafe += Coffe_OutOfBeans;
            coffe.FazerCafe();

            TratarCafe(coffe);

            Assert.Pass();
        }

        void TratarCafe(Coffee coffe)
        {
            coffe.AbastecerCafe(10);
        }

        private void Coffe_OutOfBeans(Coffee coffee, EventArgs args)
        {
            //deu ruim... fazer algo
        }
    }
}
