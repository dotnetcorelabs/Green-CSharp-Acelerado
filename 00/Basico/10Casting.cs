using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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

            decimal din = 100m;
            din = 12.4m;
            float din2 = 12f;
            din2 = 12.3f;



            double din3 = 12d;
            din3 = 12;
            din3 = 12.3;

        }

        public void ExecutaCasting()
        {
            int a;
            long b = 5;
            a = (int)b;

            // Explicit conversion of long to int. 

            //nao pode
            //int number = (int)"ekekeke";
        }

        public void ExecutaConvert()
        {
            string possibleInt = "1234";
            int count = Convert.ToInt32(possibleInt);

            
        }

        void ParseComRegex()
        {
            string semLetrasRegex = Regex.Replace("123d",
                                                  @"\w",
                                                  "",
                                                  RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.RightToLeft | RegexOptions.Singleline);
            int number = Convert.ToInt32(semLetrasRegex);
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
