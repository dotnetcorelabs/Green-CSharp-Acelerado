using System;
using System.Collections.Generic;
using System.Text;

namespace Basico02
{
    public enum Day
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class _04Enums
    {
        public _04Enums()
        {
            Day diaPreferido = Day.Friday;
            Day dia = (Day)(4);
        }
    }
}
