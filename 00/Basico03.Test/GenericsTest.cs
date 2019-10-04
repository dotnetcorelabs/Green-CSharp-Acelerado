using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Basico03.Test
{
    public class GenericsTest
    {
        [Fact]
        public void TestGenericList()
        {
            CustomList<Coffee> customList = new CustomList<Coffee>();

            customList.Add(new Coffee() { AverageRating = 10, Variety = "preto" });
            customList.Add(new Coffee() { AverageRating = 10, Variety = "marrom" });
            customList.Add(new Coffee() { AverageRating = 10, Variety = "chantily" });
            customList.Add(new Coffee() { AverageRating = 10, Variety = "creme" });

            //customList.Sort();

            Assert.Equal("preto", customList[0].Variety);
        }
    }
}
