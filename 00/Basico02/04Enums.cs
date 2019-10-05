using System;
using System.Collections.Generic;
using System.Text;

namespace Basico02
{


    class _04Enums
    {
        public enum Day
        {
            Sunday = 2,
            Monday = 4,
            Tuesday = 5,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        public _04Enums()
        {
            
            Day diaPreferido = Basico02._04Enums.Day.Friday;
            Day dia = (Day)(4);
        }
    }
}
