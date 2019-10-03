using System;
using System.Collections.Generic;
using System.Text;

namespace Basico
{
    public class _10Casting
    {
        public void ImplicitConversions()
        {
            /*
            From           To 
            sbyte          short int long float double decimal 
            byte           short ushort int uint long ulong float double decimal 
            short          int long float double decimal 
            ushort         int uint long ulong float double decimal 
            int            long float double decimal 
            uint           long ulong float double decimal 
            long ulong     float double decimal 
            float          double 
            char           ushort int uint long ulong float double decimal
             */

            int valor1 = 10;
            long valor2 = valor1;

            byte vByte = 12;
            float vFloat1 = vByte;
            double vDouble = vFloat1;
        }

        public void ExecutaCasting()
        {
            int a;
            long b = 5;
            a = (int)b;
            // Explicit conversion of long to int. 
        }

        public void ExecutaConvert()
        {
            string possibleInt = "1234";
            int count = Convert.ToInt32(possibleInt);
        }

        public void ExecutaTryParse()
        {
            int number = 0;
            string numberString = "1234";
            if (int.TryParse(numberString, out number))
            {
                // Conversion succeeded, number now equals 1234. 
            }
            else
            {
                // Conversion failed, number now equals 0. 
            }
        }
    }
}
