using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice.Helpers
{
    public static class MathHelper
    {

        /**
         * Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica 
         * uno dei principi di programmazione ad oggetti che abbiamo visto...Quale?
         * 
         * L'ereditarietà, perche il type int è compreso nel type double 
         */

        public static T NumberSumm<T>(T number1, T number2) where T : INumber<T>
        {
            return number1 + number2;
        }

        public static T NumberDiff<T>(T number1, T number2) where T : INumber<T>
        {
            return number1 - number2;
        }

        public static T NumberMultiplier<T>(T number1, T number2) where T : INumber<T>
        {
            return number1 * number2;
        }
        public static T NumberAbsolute<T>(T number1) where T : INumber<T>
        {
            return number1 < default(T) ? -number1 : number1;
        }
        public static T NumberMinor<T>(T number1, T number2) where T : INumber<T>
        {
           
            if (number1 < number2)
                return number1;
            return number2;
        }
        public static T NumberMax<T>(T number1, T number2) where T : INumber<T>
        {
            if (number1 > number2)
                return number1;
            return number2;
        }

        /**
         * Aggiungete il metodo per l’elevamento a potenza che prende come parametri due numeri interi (base ed esponente) e ritorna la base elevata all’esponente.
         */

        public static double NumberPower(int baseNumber, int power)
        {
            if(baseNumber == 0 && power == 0)
                return 1;

            if(baseNumber == 0)
                return 0;

            if(power == 0)
                return 1;

            for (int i = 1; i < Math.Abs(power); i++)
            {
                baseNumber *= baseNumber;
            }
            if (power < 0)
                return 1 / (double)baseNumber;

            return baseNumber;
        }
    }
}
