using csharp_calcolatrice.Helpers;

namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberInt = 6;
            int numberInt2 = 4;

            double numberDouble = 4.832656446548;
            double numberDouble2 = 656.5;

            //SUMM
            Console.WriteLine(MathHelper.NumberSumm(numberInt, numberInt2));
            Console.WriteLine(MathHelper.NumberSumm(numberDouble, numberDouble2));

            //DIFFERENCE
            Console.WriteLine(MathHelper.NumberDiff(numberInt, numberInt2));
            Console.WriteLine(MathHelper.NumberDiff(numberDouble, numberDouble2));

            //MULTIPLICATION
            Console.WriteLine(MathHelper.NumberMultiplier(numberInt, numberInt2));
            Console.WriteLine(MathHelper.NumberMultiplier(numberDouble, numberDouble2));

            ////ABSOLUTE
            Console.WriteLine(MathHelper.NumberAbsolute(numberInt));
            Console.WriteLine(MathHelper.NumberAbsolute(numberDouble));

            ////MINOR NUMBER
            Console.WriteLine(MathHelper.NumberMinor(numberInt, numberInt2));
            Console.WriteLine(MathHelper.NumberMinor(numberDouble, numberDouble2));

            ////MAX NUMBER
            Console.WriteLine(MathHelper.NumberMax(numberInt, numberInt2));
            Console.WriteLine(MathHelper.NumberMax(numberDouble, numberDouble2));

        }
    }
}