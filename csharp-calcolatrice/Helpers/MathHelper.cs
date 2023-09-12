using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice.Helpers
{
    public static class MathHelper
    {


        //INT FUNCTION

        public static int IntSumm(int number1, int number2) 
        {
            return number1 + number2;
        }
        
        public static int IntDiff(int number1, int number2)
        {
            return number1 - number2;
        }
        public static int IntMultiplier(int number1, int number2)
        {
            return number1 * number2;
        }
        public static   int IntAbsolute(int number1)
        {
            return Math.Abs(number1);
        }
        public static int IntMinor(int number1, int number2)
        {
            if(number1 < number2)
                return number1;
            return number2;
        }
        public static int IntMax(int number1, int number2)
        {
            if (number1 > number2)
                return number1;
            return number2;
        }
        

        //DOUBLE FUNCTION

        public static double DoubleSumm(double number1, double number2)
        {
            return number1 + number2;
        }
        public static double DoubleDiff(double number1, double number2)
        {
            return number1 - number2;
        }
        public static double DoubleMultiplier(double number1, double number2)
        {
            return number1 * number2;
        }
        public static double DoubleAbsolute(double number1)
        {
            return Math.Abs(number1);
        }
        public static double DoubleMinor(double number1, double number2)
        {
            if (number1 < number2)
                return number1;
            return number2;
        }
        public static double DoubleMax(double number1, double number2)
        {
            if (number1 > number2)
                return number1;
            return number2;
        }
    }
}
