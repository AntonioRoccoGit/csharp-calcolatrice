using System;
using System.Collections.Generic;
using System.Linq;
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

        public static double NumberSumm(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double NumberDiff(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double NumberMultiplier(double number1, double number2)
        {
            return number1 * number2;
        }
        public static double NumberAbsolute(double number1)
        {
                return Math.Abs(number1);

        }
        public static double NumberMinor(double number1, double number2)
        {
           
            if (number1 < number2)
                return number1;
            return number2;
        }
        public static double NumberMax(double number1, double number2)
        {
            if (number1 > number2)
                return number1;
            return number2;
        }

        /**
         * Aggiungete il metodo per l’elevamento a potenza che prende come parametri due numeri interi (base ed esponente) e ritorna la base elevata all’esponente.
         */

        public static double NumberPower(double baseNumber, double power)
        {
            if(baseNumber == 0 && power == 0)
                return 1;

            if(baseNumber == 0)
                return 0;

            if(power == 0)
                return 1;


            for (int i = 1; i < power; i++)
            {
                baseNumber *= baseNumber;
            }
            return baseNumber;
        }
    }
}
