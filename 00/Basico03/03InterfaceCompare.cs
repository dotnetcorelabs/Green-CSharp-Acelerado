using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basico03
{
    public class Coffee : IComparable, IComparable<Coffee>
    {
        public double AverageRating { get; set; }

        public string Variety { get; set; }

        #region IComparable
        public int CompareTo(object obj)
        {
            Coffee coffee2 = obj as Coffee;
            return CompareTo(coffee2);
        }
        #endregion IComparable

        #region IComparable<Coffee>
        public int CompareTo(Coffee other)
        {
            return string.Compare(this.Variety, other.Variety);
        }
        #endregion IComparable<Coffee>
    }
}
