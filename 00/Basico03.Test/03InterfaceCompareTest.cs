using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Basico03.Test
{
    public class InterfaceCompareTest
    {
        [Fact]
        public void TestCompare()
        {
            List<Coffee> coffies = new List<Coffee>();


            coffies.Add(new Coffee() { AverageRating = 10, Variety = "preto" });
            coffies.Add(new Coffee() { AverageRating = 10, Variety = "marrom" });
            coffies.Add(new Coffee() { AverageRating = 10, Variety = "chantily" });
            coffies.Add(new Coffee() { AverageRating = 10, Variety = "creme" });

            coffies.Sort();

            Assert.Equal("chantily", coffies[0].Variety);
        }
    }
}
